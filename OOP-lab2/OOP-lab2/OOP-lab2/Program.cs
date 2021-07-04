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

            double d3 = (double)r7;
            Console.WriteLine($"d3 = {d3}");

            Rational r8 = new Rational(6, 5);
            Console.WriteLine($"r8 = {r8}");
            double d2 = (double)r8; //явное приведение
            Console.WriteLine($"d2 = (double)r8 = {d2}");
            Rational r9 = d2;//неявное приведение
            Console.WriteLine($"r9 = d2 = {r9} ");

            Console.WriteLine("--Rational to double--");
            Console.WriteLine("Приведем -71,1 к рациональному и наоборот");
            double d4 = -71.10;
            Rational r10 = d4;
            Console.WriteLine($"r10 = d4: {d4} -> {r10} ");
            double d5 = (double)r10;
            Console.WriteLine($"d5 = r10: {r10} -> {d5} ");

            Console.WriteLine("---Summ--------------");
            Rational r11 = new Rational(2, 27);//(5, 6);
            Rational r12 = new Rational(3, 36);//(4, 9);
            Rational r13 = r11 + r12;
            Console.WriteLine($"summ: {r11} + {r12} = {r13}");






        }
    }
}
