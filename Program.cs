using System;
using System.Linq;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Flyable Implementations");
            var flyableTypes = new TypeResolver().Resolve(typeof(IFlyable));

            foreach (var types in flyableTypes)
            {
                var fv = (IFlyable)Activator.CreateInstance(types);
                fv.TakeOff();
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--------------");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Getting Vehicle Implementations");

            var vehicleTypes = new TypeResolver().Resolve(typeof(IVehicle));

            foreach (var types in vehicleTypes)
            {
                var v = (IVehicle)Activator.CreateInstance(types);
                v.Start();
            }

            Console.ReadLine();
        }
    }
}
