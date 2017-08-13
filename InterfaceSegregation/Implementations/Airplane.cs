using System;

public class Airplane : IVehicle, IFlyable
{
    public void Start()
    {
        Console.WriteLine("Airplane has started");
    }

    public void TakeOff()
    {
        Console.WriteLine("Airplane has taken off");
    }
}