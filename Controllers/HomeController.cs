using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using secondbeltexam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace secondbeltexam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("users/create")]
        public IActionResult CreateUser(User newuser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(e => e.username == newuser.username))
                {
                    ModelState.AddModelError("username", "Username is already in use.");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newuser.password = hasher.HashPassword(newuser, newuser.password);
                _context.Add(newuser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userid", newuser.userid);
                return RedirectToAction("Dashboard");
            }
            else{
                return View("Index");
            }
        }

        [HttpPost("users/login")]
        public IActionResult Login(LoginUser loginuser)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(u => u.username == loginuser.logusername);
                if (user == null)
                {
                    ModelState.AddModelError("logusername", "Invalid Username/Password");
                    return View("Index");
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(loginuser, user.password, loginuser.logpassword);
                if (result == 0)
                {
                    ModelState.AddModelError("logusername", "Invalid Username/Password");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("userid", user.userid);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.loggeduser = _context.Users.Include(i => i.createdhobbies).ThenInclude(x => x.Enthusiasts).FirstOrDefault(u => u.userid == HttpContext.Session.GetInt32("userid"));
            ViewBag.allhobbies = _context.Hobbies.Include(i => i.user).Include(x => x.Enthusiasts).ToList();
            return View();
        }

        [HttpGet("hobbies/add")]
        public IActionResult AddHobby()
        {
            if(HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("hobbies/create")]
        public IActionResult CreateHobby(Hobby newhobby)
        {
            if (ModelState.IsValid)
            {
                if (_context.Hobbies.Any(h => h.name == newhobby.name))
                {
                    ModelState.AddModelError("name", "Hobby name is already in use.");
                    return View("AddHobby");
                }
                newhobby.userid = (int)HttpContext.Session.GetInt32("userid");
                _context.Hobbies.Add(newhobby);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("AddHobby");
        }

        [HttpGet("hobbies/{id}")]
        public IActionResult OneHobby(int id)
        {
            if(HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.loggeduser = _context.Users.Include(i => i.createdhobbies).ThenInclude(x => x.Enthusiasts).FirstOrDefault(u => u.userid == HttpContext.Session.GetInt32("userid"));
            ViewBag.hobby = _context.Hobbies.Include(e => e.Enthusiasts).ThenInclude(u => u.user).FirstOrDefault(h => h.hobbyid == id);
            return View();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("hobbies/delete/{id}")]
        public IActionResult DeleteHobby(int id)
        {
            Hobby deletehobby = _context.Hobbies.SingleOrDefault(h => h.hobbyid == id);
            _context.Hobbies.Remove(deletehobby);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("enthusiasts/add/{uid}/{hid}")]
        public IActionResult AddEnthusiast(int uid, int hid)
        {
            Enthusiast enthusiasttoadd = new Enthusiast{userid = uid, hobbyid = hid};
            _context.Enthusiasts.Add(enthusiasttoadd);
            _context.SaveChanges();
            return Redirect($"/hobbies/{hid}");
        }

        [HttpGet("enthusiasts/delete/{id}")]
        public IActionResult DeleteGuest(int id)
        {
            Enthusiast enthusiasttoremove = _context.Enthusiasts.SingleOrDefault(e => e.userid == id);
            _context.Enthusiasts.Remove(enthusiasttoremove);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("hobbies/edit/{id}")]
        public IActionResult EditHobby(int id)
        {
            if(HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("Index");
            }
            Hobby hobbytoedit = _context.Hobbies.FirstOrDefault(h => h.hobbyid == id);
            return View(hobbytoedit);
        }

        [HttpPost("hobbies/update/{id}")]
        public IActionResult UpdateHobby(int id, Hobby updatedhobby)
        {
            Hobby oldhobby = _context.Hobbies.FirstOrDefault(h => h.hobbyid == id);
            if (ModelState.IsValid)
            {
                if (_context.Hobbies.Any(h => h.name == updatedhobby.name))
                {
                    ModelState.AddModelError("name", "Hobby name is already in use.");
                    return View("EditHobby", updatedhobby);
                }
                oldhobby.name = updatedhobby.name;
                oldhobby.description = updatedhobby.description;
                oldhobby.updatedat = DateTime.Now;
                _context.SaveChanges();
                return Redirect($"/hobbies/{id}");
            }
            return View("EditHobby", updatedhobby);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
