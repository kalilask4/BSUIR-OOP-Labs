using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    class MannedSpacecraft : Spacecraft
    {
        public MannedSpacecraft()
        {
        }

        public MannedSpacecraft(string name, string use, double speed) : base(name, use, speed)
        {
        }

        public void Move(Planet a, Planet b)
        {
            Console.WriteLine("Moving to " + b.Name);
        }
                
        /*
        public void Calc_time(Planet a, double path)
        {        
            Console.WriteLine("1Travel time will take " + Math.Round((a.Earth_distance + path/this.Speed), 2) + " years");
        }
        */

    }
}
