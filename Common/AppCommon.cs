using ProGCoder_Tiki_Crawl_Tool.Models;

namespace ProGCoder_Tiki_Crawl_Tool.Common;

public class AppCommon
{
    public void DisplayCategoryOption(Dictionary<string, string> categoryOptions, TikiCategoryList tikiCategoryList)
    {
        categoryOptions.Add("1", "All Categories");

        var index = 2;

        foreach (var item in tikiCategoryList.MenuBlock.Items)
        {
            categoryOptions.Add(index.ToString(), item.Text + " - " + item.CategoryId);
            index++;
        }

        foreach (var item in categoryOptions)
        {
            Console.WriteLine($"{item.Key}. {item.Value}");
        }

        Console.WriteLine();
    }

    public string GetSelectedCategory(Dictionary<string, string> categoryOptions)
    {
        while (true)
        {
            Console.Write("Enter your choice: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int selectedCategoryIndex))
            {
                if (categoryOptions.TryGetValue(selectedCategoryIndex.ToString(), out string selectedCategory))
                {
                    Console.WriteLine($"You selected: {selectedCategory}");
                    return selectedCategory == "All Categories" ? string.Empty : selectedCategory.Split(" - ").Last();
                }
            }
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    public int GetItemLimit()
    {
        while (true)
        {
            Console.Write("Enter total items per category: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int limit) && limit > 0)
            {
                return limit;
            }
            Console.WriteLine("Invalid value. Please try again.");
        }
    }
}
