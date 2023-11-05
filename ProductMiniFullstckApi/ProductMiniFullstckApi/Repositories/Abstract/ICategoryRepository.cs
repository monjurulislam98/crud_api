using ProductMiniFullstckApi.Models.Domain;

namespace ProductMiniFullstckApi.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        bool AddUpdate(Category category);
        bool Delete(int id);
        Category GetById(int id);
        IEnumerable<Category> GetAll();
    }
}
