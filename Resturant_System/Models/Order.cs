using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resturant_System.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("user")]
        public int user_id { get; set; }
        public User user { get; set; }

        public string Date { get; set; }
    }
}