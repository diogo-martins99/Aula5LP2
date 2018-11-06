using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Test
{
    class GunClip : GunDecorator
    {
        public override int AmmoCapacity { get; }

        public GunClip(Gun gun)
        {
            AmmoCapacity = gun.AmmoCapacity + 10;
            decoratedGun = gun;
        }

        public override string Render()
        {
            return $"{decoratedGun.Render()} with an extended clip";
        }
    }
}
