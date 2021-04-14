using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    //реализует 2 интерфейса - IMoving, IPromote
    class MannedSpacecraft : Spacecraft, IMoving, IPromote, IComparable  //IMoving получен из родительского, но нужно явно указывать
    {
        public new string type_object = "MannedSpacecraft";

        public new string Type_object { get => type_object; set => type_object = value; }

        public MannedSpacecraft()
        {
        }

        public MannedSpacecraft(string name, string use, double speed) : base(name, use, speed)
        {
        }

        public new void Move(Planet a, Planet b) //метод из Imoving, из родительского класса, переопределен
        {
            //Console.WriteLine(" *IMoving - Move as MannedSpacecraft");
            //Console.Write("Moving (--as a " + this.Type_object + "--).");
            Console.WriteLine("Delivery of tourists and cargo: from " + a.Name + " --> " + b.Name);  
        }

        public override void Calc_time(Planet a, double path)  //склеивание - метод из двух интерфейсов реализован 1 раз
         {
            //Console.WriteLine(" *склеивание");
            Console.Write("(Gluing)The way back and forth. ");
            //Console.Write(" (--as " + this.Type_object + "--).");
            Console.WriteLine("Travel time will take " + Math.Round(((a.Earth_distance + 2*path) / this.Speed), 2) + " years");
         }

        void IPromote.Calc_time(Planet a, double path) //кастинг
        {
            Console.WriteLine("(IPromote) Add: Choose our's trip! It only takes " + Math.Round(((a.Earth_distance + path) / this.Speed), 2) + " years");
        }

        void IMoving.Calc_time(Planet a, double path) //кастинг
        {
            Console.WriteLine("(IMoving) Travel time will take " + Math.Round(((a.Earth_distance + 2*path) / this.Speed), 2) + " years");
        }

        public void MSpacecraftIPromoteCalc_time(Planet a, double path) //обертывание
        {
            Console.WriteLine("Wrapping");
            ((IPromote)this).Calc_time(a, path);

        }

        public void MSpacecraftIMovingCalc_time(Planet a, double path) //обертывание
        {
            Console.WriteLine("Wrapping");
            ((IMoving)this).Calc_time(a, path);

        }


        void IPromote.Sell(int count_tickets)
        {
            Console.Write("Left with " + this + "place(es)");
        }

        public override string ToString() //переопределен метод родительского класса
        {
            return this.Type_object + " " + Name + " for " + Use + ". Speed: " + Speed + " au";
        }

        public int CompareTo(object obj)
        {
            //return this.Name.CompareTo(((Spacecraft) obj).Name);
            return Name.CompareTo(((Spacecraft)obj).Name);
        }
    }
}
