using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Test
{
    abstract class Gun
    {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }

        public void Fire()
        {
            Console.WriteLine($"Ammo capacity: " +
                $"{AmmoCapacity}\nNoise level: {NoiseLevel} dB");
        }

        public abstract string Render();
    }
}
