using ProGCoder_Tiki_Crawl_Tool.Common;
using ProGCoder_Tiki_Crawl_Tool.Repositories;
using ProGCoder_Tiki_Crawl_Tool.Services;
using System.Diagnostics;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var appCommon = new AppCommon();
var tikiCrawler = new TikiCrawler();

var categories = await tikiCrawler.GetCategoriesAsync();
var categoryOptions = new Dictionary<string, string>();

appCommon.DisplayCategoryOption(categoryOptions, categories);
string selectedCategory = appCommon.GetSelectedCategory(categoryOptions);

int limit = appCommon.GetItemLimit();

Console.Write("Enter search text (leave blank to get all): ");
string searchText = Console.ReadLine() ?? string.Empty;

var stopwatch = Stopwatch.StartNew();

var result = await tikiCrawler.GetProductsAsync(limit, selectedCategory, searchText);

var repository = new DataRepository();

var saveResult = await repository.SaveChangesAsync(categories, result);

stopwatch.Stop();

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("DONE!!!!!!!!");
Console.WriteLine($"TOTAL TIME: {stopwatch.ElapsedMilliseconds} ms");

