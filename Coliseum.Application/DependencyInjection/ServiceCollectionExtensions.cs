using Coliseum.Modules.Coliseums.Infrastructure.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Coliseum.Modules.Coliseums.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddColiseumApplication(this IServiceCollection services)
        {
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddColiseumInfrastructure();

            return services;
        }
    }
}
