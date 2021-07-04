using System;

namespace OOP_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(1, 2);
            Console.WriteLine($"r1={r1}");
            try
            {

                //Rational r2 = new Rational(1, 0); //здесь будет обработано исключение (знаменатель !=0)
                //Console.WriteLine($"r2={r2}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"исключение - {e.Message}");
            }
            try
            {
                Rational r3 = new Rational(0, 1); //здесь будет обработано исключение (числитель !=0)
                Console.WriteLine($"r3={r3}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"исключение - {e.Message}");
            }

        }
    }
}
