using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Modules.Coliseums.Domain.Bases;
using Coliseum.Modules.Coliseums.Domain.Warriors.Gladiators;
using Coliseum.Modules.Coliseums.Domain.Warriors.Interfaces;

namespace Coliseum.Modules.Coliseums.Infrastructure.Warriors.Factory
{
    public class WarriorFactory : IWarriorFactory
    {
        public BaseWarrior CreateWarrior(WarriorType type, string name , int damage, int maxHealth)
        {
            return type switch
            {
                WarriorType.Gladiator => Gladiator.Create( name, damage, maxHealth),
                _ => throw new ArgumentOutOfRangeException(nameof(type), $"Unknown warrior type: {type}")
            };
        }

    }
}
