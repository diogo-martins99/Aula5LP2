using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Test
{
    abstract class GunDecorator : Gun
    {
        protected Gun decoratedGun;
        public override int AmmoCapacity { get { return decoratedGun.AmmoCapacity; } }
        public override float NoiseLevel { get { return decoratedGun.NoiseLevel; } }
    }
}
