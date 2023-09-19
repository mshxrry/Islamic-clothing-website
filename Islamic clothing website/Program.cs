using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Islamic_clothing_website.Areas.Identity.Data;
namespace Islamic_clothing_website
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("IslamicClothingContextDbConnection") ?? throw new InvalidOperationException("Connection string 'IslamicClothingContextDbConnection' not found.");

            builder.Services.AddDbContext<IslamicClothingContextDb>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<IslamicClothingUser>(options => options.SignIn.RequireConfirmedAccount = false)
                 .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<IslamicClothingContextDb>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); ;

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();
            using (var scope = app.Services.CreateScope())
            {
                var roleManager =
                    scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var roles = new[] { "Admin", "Customer" };

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                        await roleManager.CreateAsync(new IdentityRole(role));
                }

            }

            using (var scope = app.Services.CreateScope())
            {
                var userManager =
                    scope.ServiceProvider.GetRequiredService<UserManager<IslamicClothingUser>>();
                var roles = new[] { "Admin", "Customer" };

                string FirstName = "Administrator";
                string LastName = "Member";
                string email = "admin@islamicattires.com";
                string password = "Attires1234,";
                if (await userManager.FindByEmailAsync(email) == null)
                {
                    var user = new IslamicClothingUser();
                    user.LastName = LastName;
                    user.FirstName = FirstName;
                    user.UserName = email;
                    user.Email = email;

                    await userManager.CreateAsync(user, password);
                    
                    await userManager.AddToRoleAsync(user, "Admin");
                }




            }


            app.Run();
        }
    }
}
