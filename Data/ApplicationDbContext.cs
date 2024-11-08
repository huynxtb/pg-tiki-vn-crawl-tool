using Microsoft.EntityFrameworkCore;
using ProGCoder_Tiki_Crawl_Tool.Entities;
using System;

namespace ProGCoder_Tiki_Crawl_Tool.Data;

public class ApplicationDbContext : DbContext
{
    private static readonly string CONNECTION_STRING = "Server=localhost,1434;Database=TikiCrawlerDB;User Id=sa;Password=123456789Aa;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False;";
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ImageEntity> Images { get; set; }
    public DbSet<ProductAttributeEntity> ProductAttributes { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<ProductImageEntity> ProductImages { get; set; }
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
    
    public ApplicationDbContext() : 
        base(new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer(CONNECTION_STRING)
            .Options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryEntity>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<ImageEntity>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<ProductAttributeEntity>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<ProductEntity>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<ProductImageEntity>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<ProductCategoryEntity>()
            .HasKey(c => c.Id);
    }
}
