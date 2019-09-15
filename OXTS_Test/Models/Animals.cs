using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OXTS_Test.Models
{
    public class Animals
    {
        public string Animal { get; set; }
        [Required]
        public string Category { get; set; }
        public string HasTail { get; set; }

        public Animals(string AnimalName, string CategoryName, string Tails)
        {
            Animal = AnimalName;
            Category = CategoryName;
            HasTail = Tails;
        }
    }
}