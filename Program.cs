using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            CarFacade carFacade = new CarFacade();

            Console.WriteLine("Starting the car...");
            carFacade.StartCar();

            Console.WriteLine("\nStopping the car...");
            carFacade.StopCar();
        }
    }
}
