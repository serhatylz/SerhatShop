using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BusinessLogic.Middlewares
{
    public static class CustomBuildServices
    {
        public static IServiceCollection AddDataConnections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("serhat"))
            );
            return services;
        }
    }
}
