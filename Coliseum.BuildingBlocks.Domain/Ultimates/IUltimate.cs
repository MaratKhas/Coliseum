using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.BuildingBlocks.Domain.Ultimates
{
    public interface IUltimate
    {
        string Name { get; }

        string GetUltimateDescription();

    }
}

