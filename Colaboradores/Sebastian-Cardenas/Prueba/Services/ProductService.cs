using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EvaluacionParcial.Models;

public class ProductService : IProductService
{
    private readonly HttpClient httpClient;

    public ProductService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<Product>> GetProducts()
    {
        return await httpClient.GetFromJsonAsync<List<Product>>("https://fakestoreapi.com/products");
    }

    public async Task<bool> DeleteProduct(int productId)
    {
        var response = await httpClient.DeleteAsync($"https://fakestoreapi.com/products/{productId}");
        return response.IsSuccessStatusCode;
    }
}
