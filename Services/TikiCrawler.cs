using ProGCoder_Tiki_Crawl_Tool.Helpers;
using ProGCoder_Tiki_Crawl_Tool.Lib;
using ProGCoder_Tiki_Crawl_Tool.Models;
using ProGCoder_Tiki_Crawl_Tool.TikiModels;
using System.Diagnostics;

namespace ProGCoder_Tiki_Crawl_Tool.Services;

public class TikiCrawler
{
    public async Task<TikiCategoryList> GetCategoriesAsync() 
    {
        var stopwatch = Stopwatch.StartNew();

        const string url = "https://api.tiki.vn";
        const string api_path = "/raiden/v2/menu-config?platform=desktop";

        var client = new PGHttpClient(url);
        var response = await client.GetAsync<TikiCategoryList>("/raiden/v2/menu-config?platform=desktop");
        response ??= new TikiCategoryList();
        response.MenuBlock ??= new MenuBlock();
        response.MenuBlock.Items ??= [];

        foreach (var item in response.MenuBlock.Items)
        {
            item.CategoryId = item.Link.ExtractCategoryId();
        }

        stopwatch.Stop();

        Console.WriteLine("--------------------------------GET CATEGORY--------------------------------");
        Console.WriteLine($"REQUEST: {url}{api_path}");
        Console.WriteLine($"TOTAL CATEGORY: {response.MenuBlock.Items.Count}");
        Console.WriteLine($"TIME: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine();

        return response;
    }

    public async Task<List<TikiProductDetail>> GetProductsAsync(int limit = 100, string categoryId = "", string searchText = "", int batchSize = 100)
    {
        var stopwatch = Stopwatch.StartNew();

        const string url = "https://tiki.vn";
        const string api_path = "/api/v2/products?limit={0}&sort=top_seller&page={1}&category={2}";

        var productIds = new Dictionary<long, string>();
        var products = new List<TikiProductDetail>();
        var categories = await GetCategoriesAsync();

        if (!string.IsNullOrEmpty(categoryId))
        {
            categories.MenuBlock.Items = categories.MenuBlock.Items.Where(s => s.CategoryId == categoryId).ToList();
        }

        var client = new PGHttpClient(url);

        foreach (var item in categories.MenuBlock.Items)
        {
            var searchParam = string.IsNullOrEmpty(searchText) ? "" : $"&q={searchText}";
            var api_path_request = string.Format(api_path, limit, 1, item.CategoryId) + searchParam;
            var response = await client.GetAsync<TikiProductList>(api_path_request);
            response ??= new TikiProductList();
            response.Data ??= [];

            foreach (var p in response.Data)
            {
                productIds.Add(long.Parse(p.Id), item.CategoryId);
            }

            Console.WriteLine($"--------------------------------GET PRODUCT BY CATEGORY {item.Text} --------------------------------");
            Console.WriteLine($"REQUEST: {url}{api_path_request}");
            Console.WriteLine($"CATEGORY \"{item.Text}\": {response.Data.Count}");
            Console.WriteLine();
        }

        foreach (var item in productIds)
        {
            var product = await GetProductAsync(item.Key, item.Value);
            products.Add(product);
        }

        stopwatch.Stop();

        Console.WriteLine($"TOTAL PRODUCT: {products.Count}");
        Console.WriteLine($"TIME: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine();

        return products;
    }

    public async Task<TikiProductDetail> GetProductAsync(long id, string catId)
    {
        var stopwatch = Stopwatch.StartNew();

        const string url = "https://tiki.vn";
        var api_path = $"/api/v2/products/{id}";

        var client = new PGHttpClient(url);
        var response = await client.GetAsync<TikiProductDetail>(api_path);

        response ??= new TikiProductDetail();
        response.CategoryId = catId;

        stopwatch.Stop();

        Console.WriteLine($"--------------------------------GET PRODUCT DETAIL {id} --------------------------------");
        Console.WriteLine($"REQUEST: {url}{api_path}");
        Console.WriteLine($"PRODUCT ID: {id}");
        Console.WriteLine($"TIME: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine();

        return response;
    }
}
