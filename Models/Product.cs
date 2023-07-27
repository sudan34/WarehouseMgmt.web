using System.ComponentModel.DataAnnotations;

namespace WarehouseMgmt.web.Models
{
    public class Product : MainModel
    {
        [Required]
        [MaxLength(60, ErrorMessage = "Max Length should be more than 60 characters")]
        [MinLength(3, ErrorMessage = "Product name should be at least 3 characters")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "Description should be more than 100 characters")]
        public string Description { get; set; }
        [Required]
        [Range(0, 999999, ErrorMessage ="Can't be less than 0 and more than 99999")]
        public string Cost { get; set; }
        [Required]
        [Range(0, 100000, ErrorMessage = "Can't be less than 0 and more than 99999")]

        public decimal Price { get; set; }
        [Required]
        public int Count { get; set; }
        public string ImageURL { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public IQueryable<Product> ProductList { get; set; }
    }
}
