using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
         Task<Products> GetProductById(int id);

         Task<IReadOnlyList<Products>> GetProducts();

         Task<IReadOnlyList<ProductBrand>> GetProductBrand();

         Task<IReadOnlyList<ProductType>> GetProductType();
    }
}