
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ClothId { get; set; }
        public Cloth Cloth { get; set; }
        public decimal Price { get; set; }
    }
}
