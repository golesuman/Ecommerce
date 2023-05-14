using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Cloth
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Category Categories { get; set; }
        public ICollection<ClothCategory> ClothCategories { get; set; }
    }

}