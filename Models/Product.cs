using System.ComponentModel.DataAnnotations;


namespace FullStackCRUD.Models
{
    public class Product
    {
        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        [StringLength(1000)]
        public string Description { get; set; }


        [Range(0, 1_000_000)]
        public decimal Price { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}