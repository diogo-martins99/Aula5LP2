using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Test
{
    class GunSilencer : GunDecorator
    {
        public override float NoiseLevel { get; }

        public GunSilencer(Gun gun)
        {
            NoiseLevel = gun.NoiseLevel/2;
            decoratedGun = gun;
        }

        public override string Render()
        {
            return $"{decoratedGun} with a silencer";
        }
    }
}
