using ProductMiniFullstckApi.Models.Domain;

namespace ProductMiniFullstckApi.Repositories.Abstract
{
    public interface IProductRepository
    {
        bool AddUpdate(Product Product);
        bool Delete(int id);
        Product GetById(int id);
        IEnumerable<Product> GetAll(string term ="");
    }
}
