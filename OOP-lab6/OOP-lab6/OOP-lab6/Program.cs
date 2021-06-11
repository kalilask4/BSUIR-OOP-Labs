using OOPlaba6;
using System;
using System.Collections;

namespace OOP_lab6
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("             ....................................");
            Console.WriteLine("\n             .    Welcome to Space observer!    . ");
            Console.WriteLine("             ....................................\n");

            Helper.Imitate_loading(" loading   .........");

            Helper.Imitate_loading(" Obj1 - Sun .........");
            Star star1 = new Star("Sun", 5778, 1);
            Console.WriteLine(star1.ToString());
            star1.print_description();

            Helper.Imitate_loading(" Obj2 - Star.........");
            Star star2 = new Star("Naos", 42000, 40, 19643814, 1076, "Zeta Puppis is a blue star in the constellation of Puppis.");
            Console.WriteLine(star2.ToString());
            star2.print_description("Suhail Khadar - the brightest roar (Arabic)");

            Helper.Imitate_loading(" Obj3 - NeutronStar..");
            NeutronStar neutronStar1 = new NeutronStar("Alma Star", 17, 111, 8, 2663568, 168000, "");
            Console.WriteLine(neutronStar1);
            neutronStar1.print_description("SN 1987A was a type II supernova in the Large Magellanic Cloud, a dwarf satellite galaxy of the Milky Way.");
           
            ArrayList astrObjects = new ArrayList();
            astrObjects.Add(star1);
            astrObjects.Add(star2);
            astrObjects.Add(neutronStar1);
            astrObjects.Add(new Star("Four", 23, 1.1));
            astrObjects.Add(star1);
            astrObjects.Add(new Star("Ann", 1, 1.3));
            astrObjects.Add("String");

            Console.WriteLine();
            Helper.launch_menu(astrObjects);
            
        }


    
}
}
