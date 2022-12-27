using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopzone.Models
{
    public class Product
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string source { get; set; }
        [Required]
        public string uploadedby { get; set; }
        [Required]
        public string uploadedat { get; set; }
        [Required]
        public string price { get; set; }
        [Required]
        public string selling_price { get; set; }
    }
}