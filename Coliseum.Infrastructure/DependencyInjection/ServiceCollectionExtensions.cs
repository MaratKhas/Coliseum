using Coliseum.BuildingBlocks.Domain;
using Coliseum.Modules.Coliseums.Domain.Warriors.Interfaces;
using Coliseum.Modules.Coliseums.Infrastructure.DomainEventDespatcher;
using Coliseum.Modules.Coliseums.Infrastructure.Repositories;
using Coliseum.Modules.Coliseums.Infrastructure.Warriors.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace Coliseum.Modules.Coliseums.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddColiseumInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDomainEventObserver, DomainEventRealTimeDespatcher>();
            services.AddSingleton<IBattleRepository, BattleInMemoryRepository>();
            services.AddSingleton<IWarriorFactory, WarriorFactory>();
            return services;
        }
    }
}
