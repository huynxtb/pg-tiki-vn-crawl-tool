using Mapster;
using Microsoft.EntityFrameworkCore;
using ProGCoder_Tiki_Crawl_Tool.Data;
using ProGCoder_Tiki_Crawl_Tool.Entities;
using ProGCoder_Tiki_Crawl_Tool.Models;
using ProGCoder_Tiki_Crawl_Tool.TikiModels;
using System.Diagnostics;

namespace ProGCoder_Tiki_Crawl_Tool.Repositories;

public class DataRepository
{

    public async Task<bool> SaveChangesAsync(TikiCategoryList tikiCategoryList, List<TikiProductDetail> tikiProductDetails)
    {
        Console.WriteLine("------------------------SAVE TO DB------------------------");
        var stopwatch = Stopwatch.StartNew();

        using (var context = new ApplicationDbContext())
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.MigrateAsync();

            var categories = new List<CategoryEntity>();
            var products = new List<ProductEntity>();
            var productCategories = new List<ProductCategoryEntity>();
            var images = new List<ImageEntity>();
            var productImgs = new List<ProductImageEntity>();
            var productAttrs = new List<ProductAttributeEntity>();

            foreach (var item in tikiCategoryList.MenuBlock.Items)
            {
                var cat = item.Adapt<CategoryEntity>();
                cat.Id = item.CategoryId;
                cat.UrlKey = item.Text.ToLower().Replace(" ", "-");
                categories.Add(cat);
            }

            foreach (var p in tikiProductDetails)
            {
                var product = p.Adapt<ProductEntity>();
                product.Brand = p.Brand?.Name;
                products.Add(product);

                productCategories.Add(new ProductCategoryEntity()
                {
                    Id = Guid.NewGuid().ToString().Replace("-", ""),
                    CategoryId = p.CategoryId,
                    ProductId = p.Id
                });

                foreach (var e in p.Images)
                {
                    var img = e.Adapt<ImageEntity>();
                    img.Id = Guid.NewGuid().ToString().Replace("-", "");
                    images.Add(img);

                    productImgs.Add(new ProductImageEntity()
                    {
                        Id = Guid.NewGuid().ToString().Replace("-", ""),
                        ProductId = p.Id,
                        ImageId = img.Id
                    });
                }

                foreach (var s in p.Specifications)
                {
                    foreach (var a in s.Attributes)
                    {
                        var attr = a.Adapt<ProductAttributeEntity>();
                        attr.Id = Guid.NewGuid().ToString().Replace("-", "");
                        attr.ProductId = p.Id;
                        productAttrs.Add(attr);
                    }
                }
            }

            context.Categories.AddRange(categories);
            context.Products.AddRange(products);
            context.Images.AddRange(images);
            context.ProductImages.AddRange(productImgs);
            context.ProductAttributes.AddRange(productAttrs);
            context.ProductCategories.AddRange(productCategories);

            await context.SaveChangesAsync();
        }

        Console.WriteLine($"TIME: {stopwatch.ElapsedMilliseconds} ms");

        stopwatch.Stop();

        return true;
    }

    private List<CategoryEntity> ToCategories(TikiCategoryList tikiCategoryList)
    {
        var result = new List<CategoryEntity>();
        foreach (var item in tikiCategoryList.MenuBlock.Items)
        {
            result.Add(new CategoryEntity()
            {
                Id = item.CategoryId,
                IconUrl = item.IconUrl,
                Link = item.Link,
                Text = item.Text,
                UrlKey = item.Text.ToLower().Replace(" ", "-"),
            });
        }
        return result;
    }
}
