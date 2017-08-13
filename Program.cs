using System;
using System.Linq;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var flyableTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IFlyable).IsAssignableFrom(p));

            foreach(var types in flyableTypes)
            {
                var fv = (IFlyable)Activator.CreateInstance(types);
                fv.TakeOff();
            }
            
            var vehicleTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IVehicle).IsAssignableFrom(p));

            foreach(var types in vehicleTypes)
            {
                var v = (IVehicle)Activator.CreateInstance(types);
                v.Start();
            }
        }
    }
}
