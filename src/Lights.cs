using System;

namespace FacadeDesignPattern
{
    class Lights
    {
        public void TurnOn() => Console.WriteLine("Lights turned on");

        public void TurnOff() => Console.WriteLine("Lights turned off");
    }
}