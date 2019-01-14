using System.ComponentModel.DataAnnotations;

namespace LabJJ2.Models
{
    public class Products
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]

        // Test for double or for currency
        public double Price { get; set; }
    }
}