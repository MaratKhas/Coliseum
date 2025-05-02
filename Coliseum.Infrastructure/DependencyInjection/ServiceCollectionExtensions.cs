using Coliseum.BuildingBlocks.Domain;
using Coliseum.Modules.Coliseums.Infrastructure.DomainEventDespatcher;
using Microsoft.Extensions.DependencyInjection;

namespace Coliseum.Modules.Coliseums.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddColiseumInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDomainEventObserver, DomainEventRealTimeDespatcher>();

            return services;
        }
    }
}
