using System.ComponentModel.DataAnnotations;

namespace MySQLAspDotNetApplication.Model
{
    public class Product
    {
        [Key]
        [Range(100, 500,ErrorMessage ="Id must be between 100 and 500")]
        public int productId { get; set; }
        [Required]
        public string? productName { get; set; }
        [Required]
        public double? price { get; set;}
        [Required]
        public int quantity { get; set;}
    }
}
