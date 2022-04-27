using System;
using System.ComponentModel.DataAnnotations;

namespace secondbeltexam.Models
{
    public class Enthusiast
    {
        [Key]
        public int enthusiastid {get;set;}

        public int userid {get;set;}

        public int hobbyid {get;set;}

        public User user {get;set;}

        public Hobby hobby {get;set;}
    }
}