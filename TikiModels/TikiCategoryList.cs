using Newtonsoft.Json;

namespace ProGCoder_Tiki_Crawl_Tool.Models;

#nullable disable
public class HighlightBlock
{
    public string Title { get; set; }
    public List<Item> Items { get; set; }
}

public class Item
{
    public string CategoryId { get; set; }
    public string Text { get; set; }
    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }
    public string Link { get; set; }
}

public class MenuBlock
{
    public string Title { get; set; }
    public List<Item> Items { get; set; }
}

public class TikiCategoryList
{
    [JsonProperty("menu_block")]
    public MenuBlock MenuBlock { get; set; }
    [JsonProperty("highlight_block")]
    public HighlightBlock HighlightBlock { get; set; }
}