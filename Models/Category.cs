﻿using System.ComponentModel.DataAnnotations;

namespace WarehouseMgmt.web.Models
{
    public class Category : MainModel
    {
        public Category() { this.Products = new HashSet<Product>(); }

        [Required]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
