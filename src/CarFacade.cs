using System;

namespace FacadeDesignPattern
{
    class CarFacade
    {
        private Engine engine;
        private Lights lights;
        private FuelSystem fuelSystem;

        public CarFacade()
        {
            engine = new Engine();
            lights = new Lights();
            fuelSystem = new FuelSystem();
        }

        public void StartCar()
        {
            engine.Start();
            lights.TurnOn();
            fuelSystem.PumpFuel();
            Console.WriteLine("Car started");
        }

        public void StopCar()
        {
            engine.Stop();
            lights.TurnOff();
            fuelSystem.StopFuelPump();
            Console.WriteLine("Car stopped");
        }
    }
}