using System;
using System.Collections;

namespace OOP_lab6_param_coll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("             ....................................");
            Console.WriteLine("\n             .    Welcome to Space observer!    . ");
            Console.WriteLine("             ....................................\n");

            Helper.Imitate_loading(" loading   .........");

            Star star1 = new Star("Sun", 5778, 1);
            Star star2 = new Star("Naos", 42000, 40, 19643814, 1076, "Zeta Puppis is a blue star in the constellation of Puppis.");
            NeutronStar neutronStar1 = new NeutronStar("Alma Star", 17, 111, 8, 2663568, 168000, "");
            Star star3 = new Star("Ann", 15233, 1.3);

            Queue stars = new Queue();
            stars.Enqueue(star1); 
            stars.Enqueue(star2); 
            stars.Enqueue(star3); 
            stars.Enqueue(neutronStar1); 
            stars.Enqueue(star1);

            Helper.launch_menu(stars);

        }
    }
}
