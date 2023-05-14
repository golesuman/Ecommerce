using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class ClothCategory
    {
        [Key]
        public int Id { get; set; }
        public int ClothId { get; set; }
        public Cloth Cloth { get; set; }
        public int CategoyId { get; set; }
        public Category Category { get; set; }
    }
}