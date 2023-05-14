using Ecommerce.Models;
namespace Ecommerce.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; set; }
        Category? GetCategoryById(int categoryId);
    }
}