using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturant_System.Models
{
    public class Pay_Type
    {
        [Key]
        public int Id { get; set; }
        public string Pay_type { get; set; }
    }
}