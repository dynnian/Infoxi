using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Infoxi.Data;
using Infoxi.Utils;

namespace Infoxi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var logHandler = new LogHandler(typeof(Program));

        // Setup database
        string? connectionString = null;
        if (builder.Environment.IsDevelopment())
        {
            // Add services to the container.
            connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                                   throw new InvalidOperationException("Connection string 'DefaultConnection' not found in appsettings.json.");
            logHandler.LogInfo(
                $"APP IS RUNNING IN DEVELOPMENT. Constructed connection string using appsettings.json: {connectionString}");
        }
        else if (builder.Environment.IsProduction())
        {
            // Construct connection string with container's environment variables
            var dbHost = Environment.GetEnvironmentVariable("DATABASE_HOST");
            var dbPort = Environment.GetEnvironmentVariable("DATABASE_PORT");
            var dbName = Environment.GetEnvironmentVariable("DATABASE_NAME");
            var dbUser = Environment.GetEnvironmentVariable("DATABASE_USER");
            var dbPassword = Environment.GetEnvironmentVariable("DATABASE_PSWD");
            connectionString = $"Host={dbHost};Port={dbPort};Database={dbName};Username={dbUser};Password={dbPassword}";
            logHandler.LogInfo(
                $"APP IS RUNNING IN PRODUCTION. Constructed connection string using environment variables: {connectionString}");
        }

        builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString
            ?? throw new InvalidOperationException("Connectionn string not found.")));
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        // Add services to the container.
        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Seed default user
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            SeedDefaultUser(userManager).Wait();
        }

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        app.Run();
    }

    // TODO: Modify identity pages to disable registration and email confirmation and focus the user management on username-password instead of email-password
    private static async Task SeedDefaultUser(UserManager<IdentityUser> userManager)
    {
        var defaultUser = new IdentityUser { UserName = "admin123", Email = "admin@example.com" };
        var user = await userManager.FindByNameAsync(defaultUser.UserName);
        if (user == null)
        {
            await userManager.CreateAsync(defaultUser, "password");
            await userManager.AddClaimAsync(defaultUser, new System.Security.Claims.Claim("RequirePasswordChange", "true"));
        }
    }
}