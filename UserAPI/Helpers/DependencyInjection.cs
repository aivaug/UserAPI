using Microsoft.Extensions.DependencyInjection;
using UserAPI.Services.Users;

namespace UserAPI.Helpers
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
