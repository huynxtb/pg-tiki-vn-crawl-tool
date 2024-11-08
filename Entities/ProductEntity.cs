namespace ProGCoder_Tiki_Crawl_Tool.Entities;

#nullable disable
public class ProductEntity
{
    public string Id { get; set; }
    public string Sku { get; set; }
    public string Name { get; set; }
    public string UrlKey { get; set; }
    public string UrlPath { get; set; }
    public string ShortUrl { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Discount { get; set; }
    public string DiscountRate { get; set; }
    public string ThumbnailUrl { get; set; }
    public string Brand { get; set; }
    public string Stock { get; set; }
}
