using Newtonsoft.Json;

namespace ProGCoder_Tiki_Crawl_Tool.Entities;

#nullable disable
public class CategoryEntity
{
    public string Id { get; set; }
    public string Text { get; set; }
    public string IconUrl { get; set; }
    public string Link { get; set; }
    public string UrlKey { get; set; }
}
