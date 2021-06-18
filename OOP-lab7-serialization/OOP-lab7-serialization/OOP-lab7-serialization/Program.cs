using System;

namespace OOP_lab7_serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carBat = new Car("Ford", "Lincoln Futura", 80, 50.0, 140, 38);
            Console.WriteLine(carBat.ToString());
            Car.SaveClass("1.txt");

            carBat.SaveObject("1.bin");
            Car carBat2 = Car.LoadObject("1.bin");
            Console.WriteLine(carBat2.ToString());
            carBat2.Serialize("2.bin");

            Car carRick = new Car("Chevrolet", "Caprice", 95, 80.0, 120, 9);
            Console.WriteLine(carRick.ToString());
            carRick = Car.Deserialize("2.bin");
            Console.WriteLine(carRick.ToString());

            Console.ReadKey();
        }
    }
}
