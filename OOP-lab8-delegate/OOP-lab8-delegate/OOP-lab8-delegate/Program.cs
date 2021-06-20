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

            carRick.addDelvoid(m1);
            carBat.addDelvoid(m1);
            //carBat.addDelvoid(m2);
            carBat.addDelvoid(delegate () { Console.WriteLine("Stop!"); }); //анонимный делегат
            carBat.addDelvoid(() => Console.WriteLine("Go!")); //лямбда

            Console.WriteLine("Вызов делегатов carRick");
            carRick.runDelvoid();
            Console.WriteLine();
            Console.WriteLine("Вызов делегатов carBat");
            carBat.runDelvoid();


            Console.WriteLine();
            Console.WriteLine("Сравнение делегатов");
            if(carBat.comparison(carRick))
            {
                Console.WriteLine("Делегаты равны");
            }
            else
            {
                Console.WriteLine("Делегаты не равны");

            }


           





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
