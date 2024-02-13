using System;
namespace FacadeDesignPattern
{
    class FuelSystem
    {
        public void PumpFuel() => Console.WriteLine("Fuel pumped");

        public void StopFuelPump() => Console.WriteLine("Fuel pump stopped");
    }

}