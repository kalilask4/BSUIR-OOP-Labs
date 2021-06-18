using System;

namespace OOP_lab7_serialization
{
    class Program
    {
        static void Main(string[] args)
        {

           // Car carBat = new Car("Ford", "Lincoln Futura", 80, 50.0, 140, 2, 2, 2.9);
            //Console.WriteLine(carBat.ToString());

            Car.SaveClass("1.txt");

            Console.ReadKey();
        }
    }
}
