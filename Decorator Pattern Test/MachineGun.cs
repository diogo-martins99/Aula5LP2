using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Test
{
    class MachineGun : Gun
    {
        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }

        public MachineGun(int ammoCapacity, float noiseLevel)
        {
            AmmoCapacity = ammoCapacity;
            NoiseLevel = noiseLevel;
        }

        public override string Render()
        {
            return "A Machine Gun";
        }
    }
}
