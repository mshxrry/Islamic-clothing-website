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
            new Customer() { CustomerId = 1, FirstName = "Josef", LastName = "Fatu", PhoneNumber = "0220567272", Email="JosefFatu@mail.com" }
          

            );

        builder.Entity<Payment>().HasData(
             new Payment() { PaymentId = 1, PaymentType = "Fatu", AmountPaid = 3 }


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