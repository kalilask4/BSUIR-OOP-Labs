using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab2
{
    class Rational
    {
        int nominator, denominator;

        public int Nominator
        {
            get
            {
                return nominator;
            }

            set
            {
                if (value == 0)
                    throw new Exception("неверный числитель");
                else
                    nominator = value;
            }
        }


        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                if (value == 0)
                    throw new Exception("неверный знаменатель");
                else
                    denominator = value;
            }
        }

        public Rational(int nominator, int denominator)
        {

            int nod = normalization(nominator, denominator); //наибольший общий делитель
            //Console.WriteLine(nod);
            if (nod != 0)
            {
                nominator = nominator / nod;
                denominator = denominator / nod;
            }
            if (denominator < 0)
            {
                denominator = Math.Abs(denominator);
                nominator = -nominator;
            }
            Nominator = nominator;
            Denominator = denominator;
        }

        public static Rational operator +(Rational a, Rational b)
        {
            int a_n = a.nominator;
            int b_n = b.nominator;
            int a_d = a.denominator;
            int b_d = b.denominator;

            return new Rational(a_n * b_d + b_n * a_d, a_d * b_d);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            int a_n = a.nominator;
            int b_n = -b.nominator;
            int a_d = a.denominator;
            int b_d = b.denominator;

            return new Rational(a_n * b_d + b_n * a_d, a_d * b_d);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            int a_n = a.nominator;
            int b_n = b.nominator;
            int a_d = a.denominator;
            int b_d = b.denominator;

            return new Rational(a_n * b_n, a_d * b_d);
        }

        public static Rational operator ++(Rational a)
        {
            int a_n = a.nominator;
            int a_d = a.denominator;

            return new Rational(a_n + 1, a_d);
        }

        public static Rational operator --(Rational a)
        {
            int a_n = a.nominator;
            int a_d = a.denominator;

            return new Rational(a_n - 1, a_d);
        }





        private static int normalization(int nominator, int denominator)
        {
            if (nominator == 0 | denominator == 0)
                throw new Exception("неверный числитель или знаменатель");
            else if (nominator / denominator == 0 | denominator / nominator == 0)
            {
                return Nod(nominator, denominator);
            }
            else return 0;

        }

        private static int Nod(int nominator, int denominator)
        {
            nominator = Math.Abs(nominator);
            denominator = Math.Abs(denominator);
            while (denominator != 0 && nominator != 0)
            {
                if (nominator % denominator > 0)
                {
                    var temp = nominator;
                    nominator = denominator;
                    denominator = temp % denominator;
                }
                else break;
            }
            if (denominator != 0 && nominator != 0) return denominator;
            return 0;
        }

        //неявная перегрузка
        public static implicit operator Rational(double d)
        {
            var array_nd = new int[2];
            array_nd = to_rational(d);
            Rational r = new Rational(array_nd[0], array_nd[1]);
            Console.WriteLine(r);
            return r;
        }

        public static explicit operator double(Rational a)
        {
            return (a.Nominator / (double)a.Denominator);
        }


        private static int[] to_rational(double d)
        {
            int counter = 0;

            //Находим показатель степени десятки такой, чтобы получить 11.55 * 10 ^ counter = 1155
            //последовательно умножаем 11.55 на 10
            while (d % 1 != 0)
            {
                d *= 10;
                counter++;
            }

            //nominator = 1155
            //denominator = 10 ^ counter = 10 ^ 2 = 100
            int nominator = (int)d;
            int denominator = (int)Math.Pow(10, counter);
            var array_nd = new int[2];
            array_nd[0] = nominator;
            array_nd[1] = denominator;

            return array_nd;
        }



        public override string ToString()
        {
            if (Denominator == 1)
                return $"{Nominator:#}";
            else
                return $"{Nominator:#}/{Denominator:#}";
        }


    }
}
