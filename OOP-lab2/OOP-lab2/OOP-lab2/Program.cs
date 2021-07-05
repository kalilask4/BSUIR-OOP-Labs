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

            //Для проверки приведем к double и сравним суммы
            double d6 = (double)r13;
            double d7 = (double)r11;
            double d8 = (double)r12;
            double d9 = d7 + d8;
            Console.WriteLine($"summ: {d7} + {d8} = {d9}. d6 = {d6}"); //для проверки

            Console.WriteLine("--Subtraction---------");
            Rational r14 = new Rational(3, 27);
            Rational r15 = new Rational(2, 27);
            Rational r16 = r14 - r15;
            Console.WriteLine($"Sub: {r14} - {r15} = {r16}");

            Console.WriteLine("--Multiplication------");
            //Rational r14 = new Rational(3, 27);
            //Rational r15 = new Rational(2, 27);
            Rational r20 = r14 * r15;
            Console.WriteLine($"Mul: {r14} * {r15} = {r20}");

            Console.WriteLine("--operator++--------");
            Rational r21 = r20++;
            Console.WriteLine($"++: {r20++} = {r21}");

            Console.WriteLine("operator--");
            Rational r22 = r21--;
            Console.WriteLine($"--: {r22}-- {r22--}");

            Console.WriteLine("--operator!= и ==-------");
            Rational r23 = new Rational(3, 27);
            Rational r24 = new Rational(3, 27);
            Console.WriteLine($"==: {r23 == r24}");
            Console.WriteLine($"!=: {r23 != r24}");
            Console.WriteLine($"==: {r22 == r24}");
            Console.WriteLine($"!=: {r22 != r24}");

            Console.WriteLine("--operator true & false -------");
            Rational r25 = new Rational(0, 4);
            if (r24)
            {
                Console.WriteLine($"{r24} - true");
            }
            else
            {
                Console.WriteLine($"{r24} - false");
            }

            if (r25)
            {
                Console.WriteLine($"{r25} - true");
            }
            else
            {
                Console.WriteLine($"{r25} - false");
            }

            Console.WriteLine("--indexer -------");
            try
            {
            Console.WriteLine($"{r20} > r20[0] = {r20[0]}, r20[1] = {r20[1]}");
            Console.WriteLine($"{r20[2]}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"исключение -  { e.Message}");
            }
            Console.Write($"{r6} > r6[0] = 2: ");
            r6[0]=2;
            Console.WriteLine(r6.ToString());
            Console.Write($"{r6} > r6[1] = 5: ");
            r6[1] = 5;
            Console.WriteLine(r6.ToString());
           




        }
    }
}
