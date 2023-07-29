using System.ComponentModel.DataAnnotations;

namespace MySQLAspDotNetApplication.Model
{
    public class Product
    {
        [Key]
        [Range(100, 500,ErrorMessage ="Id must be between 100 and 500")]
        [Display(Name = "Product Id")]
        public int productId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string? productName { get; set; }
        [Required]
        [Display(Name = "Price Of Product")]
        public double? price { get; set;}
        [Required]
        [Display(Name ="No of Quantity")]
        public int quantity { get; set;}
    }
}
