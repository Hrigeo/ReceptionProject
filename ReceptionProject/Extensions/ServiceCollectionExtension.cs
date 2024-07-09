using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReceptionProject.Data;

namespace ReceptionProject.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return null!;
        }
        public static IServiceCollection AddApplicationDbContext (this IServiceCollection services,IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ReceptionDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
            })
    .AddEntityFrameworkStores<ReceptionDbContext>();
            
            return services;
        }
    }
}
