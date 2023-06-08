using Islamic_clothing_website.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Islamic_clothing_website.Models;

namespace Islamic_clothing_website.Areas.Identity.Data;

public class IslamicClothingContextDb : IdentityDbContext<IslamicClothingUser>
{
    public IslamicClothingContextDb(DbContextOptions<IslamicClothingContextDb> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    private class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<IslamicClothingUser>
    {
        public void Configure(EntityTypeBuilder<IslamicClothingUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }

    public DbSet<Islamic_clothing_website.Models.Customer>? Customer { get; set; }

    public DbSet<Islamic_clothing_website.Models.Order>? Order { get; set; }

    public DbSet<Islamic_clothing_website.Models.Product>? Product { get; set; }
}
