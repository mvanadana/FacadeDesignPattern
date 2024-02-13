using System;

namespace FacadeDesignPattern
{

    class Engine
    {
        public void Start() => Console.WriteLine("Engine started");

        public void Stop() => Console.WriteLine("Engine stopped");
    }
}