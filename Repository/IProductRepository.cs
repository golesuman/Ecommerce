using Ecommerce.Models;
namespace Ecommerce.Services
{
    public interface IProductRepository
    {
        IEnumerable<Cloth> AllProducts { get; set; }
        Cloth? GetClothById(int ClothId);
    }
}