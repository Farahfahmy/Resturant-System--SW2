using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resturant_System.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("order")]
        public int Order_id { get; set; }
        public Order order { get; set; }

        public float Total_Bill { get; set; }
    }
}