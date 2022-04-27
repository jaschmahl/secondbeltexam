using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace secondbeltexam.Models
{
    public class Hobby
    {
        [Key]
        public int hobbyid {get;set;}

        [Required(ErrorMessage = "Name is required.")]
        public string name {get;set;}

        [Required(ErrorMessage = "Description is required.")]
        public string description {get;set;}

        public int userid {get;set;}

        public User user {get;set;}

        public List<Enthusiast> Enthusiasts {get;set;}

        public DateTime createdat {get;set;} = DateTime.Now;

        public DateTime updatedat {get;set;} = DateTime.Now;
    }
}