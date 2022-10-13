using System;

namespace Car
{
    class Vehicle
    {
        public string brand = "Ford";
        public void punk()
        {
            Console.WriteLine("Tuuuut!");
        }
    }
    class Car : Vehicle
    {
        public string model = "Mustang";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.punk();
            Console.WriteLine(myCar.brand + " " + myCar.model);

        }
    }
}
