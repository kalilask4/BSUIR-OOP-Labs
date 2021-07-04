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

        public override string ToString()
        {
            if (Denominator == 1)
                return $"{Nominator:#}";
            else
                return $"{Nominator:#}/{Denominator:#}";
        }


    }
}
