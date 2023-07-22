using System.Collections.Generic;
using System.Threading.Tasks;
using Prueba.Models;

public interface IProductService
{
    Task<List<Product>> GetProducts();
    Task<bool> DeleteProduct(int productId);
}
