

using System;

namespace VehicleConfigurationSystem
{


    // Rule +  methodImplemention
    abstract class Vechile
    {
        public string FuelType { get; set; }
        public int Capacity { get; set; }

        public abstract  void  Start();

        public abstract  void  Stop();

        public abstract void Engine();


        //Concrete methods
        public void ShowDetails()
        {
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Capacity: {Capacity} passengers");
        }

    }


    //Derive Class  or Child Class

    class Car : Vechile
    {
        public override  void Start()
        {
 
            Console.WriteLine("Car is starting with a key ignition.");
        }

        public override void Stop()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Car has stopped .");
        }

        public override void Engine()
        {
            Console.WriteLine("Car engine is a 4-cylinder petrol engine.");
        }


        public void CarPurcahseDateandTime()
        {
            Console.WriteLine("12-06-2024:12:35:00");
        }

    }



    class Bike : Vechile
    {
        public override void Engine()
        {
            //throw new NotImplementedException();
        }

        public override void Start()
        {
            //throw new NotImplementedException();
        }

        public override void Stop()
        {
         //   throw new NotImplementedException();
        }
    }

    class Program
    {
        public static void Main()
        {

        }
    }


}