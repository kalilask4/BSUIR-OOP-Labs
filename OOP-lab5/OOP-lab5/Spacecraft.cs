using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    //реализует 1 интерфейс - Imoving
    class Spacecraft : IMoving
    {
        string name;
        string use;
        double speed; //расчет скоростей и расстояний упрощен. а.е
        public string type_object = "Spacecraft";

        public string Name { get => name; set => name = value; }
        public string Use { get => use; set => use = value; }
        public double Speed { get => speed; set => speed = value; }
        public string Type_object { get => type_object; set => type_object = value; }

        public Spacecraft()
        {
        }

        public Spacecraft(string name, string use, double speed)
        {
            Name = name;
            Use = use;
            Speed = speed;
        }

        //Если точка назначения не планета
        /* public void Move(Planet a, string destination)
         {
             Console.WriteLine("Moving from " + a + "to " + destination);
         }*/


        public void Move(Planet a, Planet b) //реализован метод интерфейса IMoving
        {
            Console.WriteLine(" *IMoving - Move as a Spacecraft");
            Console.Write("Moving (--as a " + this.Type_object + "--) - interplanetary flight: ");
            Console.WriteLine(a.Name + " ---> " + b.Name);
        }


        //Расчет в одну сторону
        public virtual void Calc_time(Planet a, double path)
        {
            Console.WriteLine(" *IMoving - Calc_time");
            Console.Write("Will arrive for research (--as a " + this.Type_object + "--) in ");
            Console.WriteLine(Math.Round(((a.Earth_distance + path) / this.Speed), 2) + " years");
        }

        public override string ToString() //переопределен метод родительского класса
        {
            return this.Type_object + " " + Name + " for " + Use + ". Speed: " + Speed + " au";
        }

    }
}
