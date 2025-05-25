using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Modules.Coliseums.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Modules.Coliseums.Domain.Warriors.Interfaces
{
    public interface IWarriorFactory
    {
        BaseWarrior CreateWarrior(WarriorType type, string name, int damage, int maxHealth);
    }
}
