using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace secondbeltexam.Models
{
    public class User
    {
        [Key]
        public int userid {get;set;}

        [Required(ErrorMessage = "First Name is required.")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters.")]
        public string firstname {get;set;}

        [Required(ErrorMessage = "Last Name is required.")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters.")]
        public string lastname {get;set;}

        [Required(ErrorMessage = "Username is required.")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters.")]
        [MaxLength(15, ErrorMessage = "Username must be less than 15 characters.")]
        public string username {get;set;}

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string password {get;set;}

        public List<Enthusiast> enthusiasts {get;set;}

        public List<Hobby> createdhobbies {get;set;}

        public DateTime createdat {get;set;} = DateTime.Now;

        public DateTime updatedat {get;set;}= DateTime.Now;

        [NotMapped]
        [Required(ErrorMessage = "Must confirm password.")]
        [Compare("password", ErrorMessage = "Password doesn't match confirm password.")]
        [DataType(DataType.Password)]
        public string confirm {get;set;}
    }
}