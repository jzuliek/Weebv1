using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Weebapi.Data;
using Weebapi.Interfaces;
using Weebapi.Services;

namespace Weebapi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices( this IServiceCollection services, 
            IConfiguration config)
            {
                services.AddDbContext<DataContext>(opt => 
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

                services.AddCors();
                services.AddScoped<ITokenService, TokenService>();

                return services;
            }
    }
}