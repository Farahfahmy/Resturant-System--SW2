using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resturant_System.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("order")]
        public int Total_Price { get; set; }
        public Order order { get; set; }


        [ForeignKey("pay_type")]
        public int py_type_id { get; set; }
        public Pay_Type pay_type { get; set; }
    }
}