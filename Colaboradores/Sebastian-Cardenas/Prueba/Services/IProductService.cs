using System.Collections.Generic;
using System.Threading.Tasks;
using EvaluacionParcial.Models;

public interface IProductService
{
    Task<List<Product>> GetProducts();
    Task<bool> DeleteProduct(int productId);
}
