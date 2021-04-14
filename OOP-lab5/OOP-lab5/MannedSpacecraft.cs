using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    //реализует 2 интерфейса - IMoving, IPromote
    class MannedSpacecraft : Spacecraft, IMoving, IPromote  //IMoving получен из родительского, но нужно явно указывать
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
            Console.WriteLine(" *IMoving - Move as MannedSpacecraft");
            Console.Write("Moving (--as a " + this.Type_object + "--).");
            Console.WriteLine("Delivery of tourists and cargo: from " + a.Name + " --> " + b.Name);
            //Console.WriteLine(a.Name + " ------> " + b.Name);
        }

        public override void Calc_time(Planet a, double path)  //склеивание - метод из двух интерфейсов реализован 1 раз
         {
            //Console.WriteLine(" *склеивание");
            Console.Write("The way back and forth (--as " + this.Type_object + "--). ");
            Console.WriteLine("Travel time will take ()" + Math.Round(((2*a.Earth_distance + path) / this.Speed), 2) + " years");
         }

        void IPromote.Calc_time(Planet a, double path) //кастинг
        {
            Console.Write("Add: Chose our's trip! It takes " + Math.Round(((a.Earth_distance + path) / this.Speed), 2) + " years");
        }

        void IMoving.Calc_time(Planet a, double path) //кастинг
        {
            Console.WriteLine("Travel time will take ()" + Math.Round(((2 * a.Earth_distance + path) / this.Speed), 2) + " years");
        }


        void IPromote.Sell(int count_tickets)
        {
            Console.Write("Left with " + this + "place(es)");
        }

        public override string ToString() //переопределен метод родительского класса
        {
            return this.Type_object + " " + Name + " for " + Use + ". Speed: " + Speed + " au";
        }




    }
}
