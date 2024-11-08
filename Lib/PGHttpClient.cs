using Newtonsoft.Json;
using System.Text;

namespace ProGCoder_Tiki_Crawl_Tool.Lib;

public class PGHttpClient
{
    private readonly HttpClient _httpClient;

    public PGHttpClient(string baseAddress)
    {
        _httpClient = new HttpClient()
        {
            BaseAddress = new Uri(baseAddress)
        };
    }

    public void SetDefaultRequestHeaders(string key, string value)
    {
        _httpClient.DefaultRequestHeaders.Add(key, value);
    }

    public async Task<T> GetAsync<T>(string requestUri)
    {
        try
        {
            var response = await _httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(json)) return default!;

            var result = JsonConvert.DeserializeObject<T>(json);

            return result ?? default!;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error during GET request: {e.Message}");
            return default!;
        }
    }

    public async Task<T> PostAsync<T>(string requestUri, T data)
    {
        try
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(requestUri, content);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(json)) return default!;

            var result = JsonConvert.DeserializeObject<T>(json);

            return result ?? default!;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error during GET request: {e.Message}");
            return default!;
        }
    }
}