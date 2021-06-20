using System;

namespace OOP_lab8_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carBat = new Car("Ford", "Lincoln Futura", 80, 50.0, 140, 38);
            Console.WriteLine(carBat.ToString());
            Car carRick = new Car("Chevrolet", "Caprice", 95, 80.0, 120, 9);
            Console.WriteLine(carRick.ToString());

            //carBat.delvoid += m1;
            //carBat.delvoid();

            carBat.addDelvoid(m1);
            carBat.runDelvoid(m1);







            Console.ReadKey();
        }

        static void m1()
        {
            Console.WriteLine("Ready Player1");
        }

        static void m2()
        {
            Console.WriteLine("Ready Player2");
        }


    }
}
