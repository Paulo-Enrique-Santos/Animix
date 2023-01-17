using Animix.Domain.Interface.Repository;
using Animix.Domain.Interface.Service;
using Animix.Domain.Service;
using Animix.Infrastructure.Context;
using Animix.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Animix.Infrastructure.Injection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("ConnectionSqlite")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAnimationRepository, AnimationRepository>();
            services.AddScoped<ICharacterRepository, CharacterRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAnimationService, AnimationService>();
            services.AddScoped<ICharacterService, CharacterService>();

            return services;
        }
    }
}
