using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;

namespace PruebaG5;

public interface IProductService
   {
        Task<List<Product>> GetProducts();
        Task Delete(int productId);
    }

