using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun myMachineGun = new MachineGun(80, 20);
            Gun myShotGun = new ShotGun(8, 30);

            myShotGun.Fire();
            myMachineGun.Fire();
            myShotGun.Render();
            myMachineGun.Render();

            GunDecorator silencedShotGun = new GunSilencer(myShotGun);
            GunDecorator silencedMachineGun = new GunSilencer(myMachineGun);

            Console.WriteLine("\nSilencer equiped on both weapons\n");

            silencedShotGun.Fire();
            silencedMachineGun.Fire();
            silencedShotGun.Render();
            silencedMachineGun.Render();

            GunDecorator extendedShotGun = new GunClip(myShotGun);
            GunDecorator extendedMachineGun = new GunClip(myMachineGun);

            Console.WriteLine("\nExtended clip equiped on both weapons\n");

            extendedShotGun.Fire();
            extendedMachineGun.Fire();
            extendedShotGun.Render();
            extendedMachineGun.Render();

        }
    }
}
