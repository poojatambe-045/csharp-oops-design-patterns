using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.Design_Patterns
{
    public interface IVehicle
    {
        string VehicleType();
        int NumberOfWheels();
    }

    class Bike : IVehicle
    {
        private readonly int Wheels;
        public Bike()
        {
            this.Wheels = 2;
        }
        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Bike";
        }
    }
    class Car : IVehicle
    {
        private readonly int Wheels;
        public Car()
        {
            this.Wheels = 4;
        }
        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Car";
        }
    }
    class Rikshaw : IVehicle
    {
        private readonly int Wheels;
        public Rikshaw()
        {
            this.Wheels = 3;
        }
        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Rikshaw";
        }
    }

    class VehicalFactory
    {
        public static IVehicle getVehicle(String type)
        {
            IVehicle ObjectType = null;
            if (type.ToLower().Equals("bike"))
            {
                ObjectType = new Bike();
            }
            if (type.ToLower().Equals("car"))
            {
                ObjectType = new Car();
            }
            if (type.ToLower().Equals("rikshaw"))
            {
                ObjectType = new Rikshaw();
            }
            return ObjectType;
        }
    }
    class Factory
    {
        static void Main(string[] args)
        {
            string inputFromConsole = null;
            Console.WriteLine("Enter the Vehicle Type");
            inputFromConsole = Console.ReadLine();
            IVehicle type=VehicalFactory.getVehicle(inputFromConsole);
            Console.WriteLine("Type is " + type.VehicleType());
            Console.WriteLine("Number of wheel is "+ type.NumberOfWheels());
            Console.ReadKey();
        }
    }
}



//Enter the Vehicle Type
//car
//Type is Car
//Number of wheel is 4