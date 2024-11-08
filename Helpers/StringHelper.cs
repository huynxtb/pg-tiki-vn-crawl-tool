using System.Text.RegularExpressions;

namespace ProGCoder_Tiki_Crawl_Tool.Helpers;

public static class StringHelper
{
    public static string ExtractCategoryId(this string url)
    {
        var value = url.Split('/').Last();
        return value.Replace("c", string.Empty);
    }
}
