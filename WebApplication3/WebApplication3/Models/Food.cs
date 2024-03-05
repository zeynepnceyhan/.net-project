using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Food
    {
        [Key]
        public int ProductId { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }
        public string Exp { get; set; }
    }
}