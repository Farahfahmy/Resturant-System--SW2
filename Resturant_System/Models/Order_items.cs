using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resturant_System.Models
{
    public class Order_items
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("order")]
        public int order_id { get; set; }
        public Order order { get; set; }


        [ForeignKey("items")]
        public int item_id { get; set; }
        public Items items { get; set; }
    }
}