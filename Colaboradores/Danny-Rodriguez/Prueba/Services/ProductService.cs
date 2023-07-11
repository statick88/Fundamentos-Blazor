using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PruebaG5;

public class ProductService : IProductService
{
    private readonly HttpClient httpClient;

    public ProductService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<Product>> GetProducts()
    {
        var response = await httpClient.GetAsync("api/products");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var products = JsonSerializer.Deserialize<List<Product>>(content);
            return products;
        }
        else
        {
            throw new Exception("No se pudieron obtener los productos.");
        }
    }

    public async Task Delete(int productId)
    {
        var response = await httpClient.DeleteAsync($"v1/products/{productId}");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
    }

}

