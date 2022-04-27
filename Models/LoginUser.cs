using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace secondbeltexam.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Username is required.")]
        [MinLength(2, ErrorMessage = "Username must be at least 3 characters.")]
        [MaxLength(15, ErrorMessage = "Username must be less than 15 characters.")]
        public string logusername {get;set;}

        [Required(ErrorMessage = "Email is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        public string logpassword {get;set;}
    }
}