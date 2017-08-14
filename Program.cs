using System;
using System.Collections.Generic;
using System.Linq;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Vehicle Implementations");
            Console.WriteLine(Environment.NewLine);

            IEnumerable<Type> vehicleTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IVehicle).IsAssignableFrom(p) && !p.IsInterface);

            Console.WriteLine("--------------");
            Console.WriteLine(Environment.NewLine);

            foreach (var types in vehicleTypes)
            {
                var v = (IVehicle)Activator.CreateInstance(types);
                v.Start();
            }

            Console.WriteLine("Getting Flyable Implementations");
            var flyableTypes = vehicleTypes.Where(x => x.IsAssignableFrom(typeof(IFlyable)));

            foreach (var types in flyableTypes)
            {
                var fv = (IFlyable)Activator.CreateInstance(types);
                fv.TakeOff();
            }

            Console.ReadLine();
        }
    }
}
