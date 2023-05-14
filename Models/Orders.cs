using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Ecommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}