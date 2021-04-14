using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    //реализует 2 интерфейса - IMoving, IPromote
    class MannedSpacecraft : Spacecraft, IMoving, IPromote  //IMoving получен из родительского, здесь указан явно
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
            Console.WriteLine("Travel time will take ()" + Math.Round((a.Earth_distance + path / this.Speed), 2) + " years");
         }

        void IPromote.Calc_time(Planet a, double path) //кастинг
        {
            throw new NotImplementedException();
        }

        void IMoving.Calc_time(Planet a, double path) //кастинг
        {
            throw new NotImplementedException();
        }


        void IPromote.Sell()
        {
            throw new NotImplementedException();
        }

        public override string ToString() //переопределен метод родительского класса
        {
            return this.Type_object + " " + Name + " for " + Use + ". Speed: " + Speed + " au";
        }




    }
}
