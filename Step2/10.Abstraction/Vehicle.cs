

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
            Console.WriteLine("Bike engine is a 2-stroke petrol engine.");
        }

        public override void Start()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Bike is starting with a self-start or kick-start.");
        }

        public override void Stop()
        {
         //   throw new NotImplementedException();
        }
    }

    // 1. For Abastract class you cnnot create instance
    // 2. But Abstract class we can refer the to the child or dervied classs
    class Program
    {
        public static void Main()
        {
            //Vechile carVehicle = new Car();
            //carVehicle.FuelType = "Petril";
            //carVehicle.Capacity = 5;

            Vechile carVehicle = new Car()
            {
                Capacity = 5,
                FuelType = "Petrol"
            };

            carVehicle.ShowDetails(); // Focus on essentials (high-level details) //concreate method
            carVehicle.Start(); // abstart method.
            carVehicle.Stop();  // abstract method.
            carVehicle.Engine();


            Vechile bikeVehicle = new Bike()
            {
                Capacity = 1,
                FuelType = "Petrol"
            };

            bikeVehicle.ShowDetails(); // Focus on essentials (high-level details) //concreate method
            bikeVehicle.Start(); // abstart method.
            bikeVehicle.Stop();  // abstract method.
            bikeVehicle.Engine();
        }
    }


}