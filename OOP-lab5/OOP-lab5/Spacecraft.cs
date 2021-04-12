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

        public string Name { get => name; set => name = value; }
        public string Use { get => use; set => use = value; }
        public double Speed { get => speed; set => speed = value; }

        public Spacecraft()
        {
        }

        public Spacecraft(string name, string use, double speed)
        {
            Name = name;
            Use = use;
            Speed = speed;
        }

        public override string ToString()
        {
            return "Spacecraft " + Name + " for " + Use + ". Speed: " + Speed + " au";
        }

        public void Move(Planet a, Planet b)
        {
            Console.WriteLine("Moving to " + b.Name);
        }

        //Если точка назначения не планета
       /* public void Move(Planet a, string destination)
        {
            Console.WriteLine("Moving from " + a + "to " + destination);
        }*/

        //Расчет в одну сторону
        public void Calc_time(Planet a, double path)
        {
            Console.WriteLine("Path long " + Math.Round((a.Earth_distance + path / this.Speed), 2) + " years");
        }



    }
}
