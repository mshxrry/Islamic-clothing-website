using Islamic_clothing_website.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Islamic_clothing_website.Areas.Identity.Data;


namespace Islamic_clothing_website.Areas.Identity.Data;

public class IslamicClothingContextDb : IdentityDbContext<IslamicClothingUser>
{
    public IslamicClothingContextDb(DbContextOptions<IslamicClothingContextDb> options)
        : base(options)
    {
    }

    public DbSet<Islamic_clothing_website.Models.Customer>? Customer { get; set; }

    public DbSet<Islamic_clothing_website.Models.Order>? Order { get; set; }

    public DbSet<Islamic_clothing_website.Models.Product>? Product { get; set; }

    public DbSet<Islamic_clothing_website.Models.Payment>? Payment { get; set; }

    public DbSet<Islamic_clothing_website.Models.Delievery>? Delievery { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Customer>().HasData(
            new Customer() { CustomerId = 1, FirstName = "Josef", LastName = "Fatu", PhoneNumber = "0220567272", Email="JosefFatu@mail.com" },
            new Customer() { CustomerId = 2, FirstName = "Aayush", LastName = "Bhandari", PhoneNumber = "0210298712", Email = "Aayush21@gmail.com"},
            new Customer() { CustomerId = 3, FirstName = "Sajal", LastName = "Taneja", PhoneNumber = "021029562", Email = "Sajal092@gmail.com"},
            new Customer() { CustomerId = 4, FirstName = "Muhammad", LastName = "Shaharyar", PhoneNumber = "0210897166", Email = "shery.08@gmail.com" },
            new Customer() { CustomerId = 5, FirstName = "Sujal", LastName = "Chand", PhoneNumber = "020295177", Email = "sujal244@outlook.com" }
            );

      


        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }



    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<IslamicClothingUser>
    {
        public void Configure(EntityTypeBuilder<IslamicClothingUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(250);
            builder.Property(u => u.LastName).HasMaxLength(250);
        }
    }
}