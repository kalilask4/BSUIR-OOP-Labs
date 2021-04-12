using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    //реализует 2 интерфейса - Imoving, Ipromote
    class MannedSpacecraft : Spacecraft /*Imoving, Ipromote*/
    {
        public MannedSpacecraft()
        {
        }

        public MannedSpacecraft(string name, string use, double speed) : base(name, use, speed)
        {
        }

        public new void Move(Planet a, Planet b) //метод из Imoving, из родительского класса, переопределен
        {
            Console.WriteLine("Traveling from " + a.Name + " to " + b.Name);
        }



        public void Calc_time(Planet a, double path)
         {
             Console.WriteLine("Travel time will take " + Math.Round((a.Earth_distance + path / this.Speed), 2) + " years");
         }

        /*
        void Ipromote.Calc_time(Planet a, double path)
        {
            throw new NotImplementedException();
        }

        void Ipromote.Sell()
        {
            throw new NotImplementedException();
        }

        */

    }
}
