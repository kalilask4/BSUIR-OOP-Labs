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
                //Rational r3 = new Rational(0, 1); //здесь будет обработано исключение (числитель !=0)
                //Console.WriteLine($"r3={r3}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"исключение - {e.Message}");
            }

            Console.WriteLine($"В конструктор передаем 9,-3");
            Rational r4 = new Rational(9, -3);
            Console.WriteLine($"r4={r4}");
            Console.WriteLine($"В конструктор передаем -9,-3");
            Rational r5 = new Rational(-9, -3);
            Console.WriteLine($"r5={r5}");
            Console.WriteLine($"В конструктор передаем 10,-3");
            Rational r6 = new Rational(10, -3);
            Console.WriteLine($"r6={r6}");
            Console.WriteLine("-----------------");
            //приведение типа
            double d1 = -19.5;
            Rational r7 = d1;//неявное приведение
            Console.WriteLine($"r7 = {r7}");




        }
    }
}
