﻿using System.ComponentModel.DataAnnotations;

namespace Practice1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public DateTime ExpiryDate { get; set; xdsd
        public DateTime ManufacturedDate { get; set; }
    }
}
