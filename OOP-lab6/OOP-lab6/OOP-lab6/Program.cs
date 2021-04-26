using System;

namespace OOP_lab6
{
    class Program
    {
        static void Main(string[] args)
        {




            Star star1 = new Star("Sun", 5778, 1);
            Console.WriteLine(star1.ToString());
            star1.print_description();

            Star star2 = new Star("Naos", 42000, 40, 19643814, 1076, "Zeta Puppis is a blue star in the constellation of Puppis.");
            star2.print_description("Suhail Khadar - the brightest roar (Arabic)");

            NeutronStar neutronStar1 = new NeutronStar("Alma Star", 17, 111, 8, 2663568, 168000, "");
            Console.WriteLine(neutronStar1);
            neutronStar1.print_description("SN 1987A was a type II supernova in the Large Magellanic Cloud, a dwarf satellite galaxy of the Milky Way.");

          
        }


    
}
}
