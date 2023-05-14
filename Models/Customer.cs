using Microsoft.AspNetCore.Identity;
namespace Ecommerce.Models
{
    public class Customer : IdentityUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}