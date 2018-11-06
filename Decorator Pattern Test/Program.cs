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

            //Shotgun info
            Console.WriteLine(myShotGun.Render() + ":");
            myShotGun.Fire();

            //Machine Gun info
            Console.WriteLine(myMachineGun.Render() + ":");
            myMachineGun.Fire();

            GunDecorator silencedShotGun = new GunSilencer(myShotGun);
            GunDecorator silencedMachineGun = new GunSilencer(myMachineGun);

            SeparationText();

            Console.WriteLine("\n\nSilencer equiped on both weapons\n");

            //Shotgun info
            Console.WriteLine(silencedShotGun.Render() + ":");
            silencedShotGun.Fire();

            //Machine Gun info
            Console.WriteLine(silencedMachineGun.Render() + ":");
            silencedMachineGun.Fire();


            GunDecorator extendedShotGun = new GunClip(silencedShotGun);
            GunDecorator extendedMachineGun = new GunClip(myMachineGun);

            SeparationText();

            Console.WriteLine("\n\nExtended clip equiped on the previous " +
                "Shotgun and on a new Machine Gun\n");

            //Shotgun info
            Console.WriteLine(extendedShotGun.Render() + ":");
            extendedShotGun.Fire();

            //Machine Gun info
            Console.WriteLine(extendedMachineGun.Render() + ":");
            extendedMachineGun.Fire();

            void SeparationText()
            {
                for (int i = 0; i < 50; i++) Console.Write("|");
            }
        }
    }
}
