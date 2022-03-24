using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Car
    {
        public String make;
        public String model;
        public int year;
        public String color;
        public static int numberOfCars;       

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            numberOfCars++;
        }

        public void Drive ()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun");
        }

        public static void ChangeColor (Car car, string color)
        { 
            car.color = color;
            Console.WriteLine("CHANGING COLOR PSSSSHHHT");
        }

        public static Car Copy(Car car)
        {
            Console.WriteLine("Copying " + car.make + " " + car.model+ " " + car.year + " " + car.color);
            return new Car(car.make, car.model, car.year, car.color);
        }

        public override string ToString()
        {           
            return "This is a " + make + " " + model;
        }
    }
}
