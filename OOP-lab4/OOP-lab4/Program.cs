using OOPlaba4;
using System;
using System.Threading;

namespace OOP_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space observer!");
            AstronomicalObject a0; //объект абстрактного класса создавать нельзя, но можно создать ссылку, в которую можно будет положить наследника
            //AstronomicalObject a1 = new AstronomicalObject(); 
            //Console.WriteLine(a1.Name);
            //Console.WriteLine(a1);
           Thread.Sleep(1000);
            Console.Write(".....");
            Thread.Sleep(1000);
            Console.Write("......");
            Thread.Sleep(1000);
            Console.Write("...");
            Thread.Sleep(1000);
            Console.Write("..");
            Console.WriteLine("......");
            Thread.Sleep(2000);
            Console.WriteLine("\n------------ Obj1 - Sun ------------");
            Star star1 = new Star("Sun", 5778, 1);
            Console.WriteLine(star1.ToString());
            star1.print_description(); //метод род.кл. переопределен
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(2000);
            Console.WriteLine("\n------------ Obj2 - Star ------------");
            Star star2 = new Star("Naos", 42000, 40, 19643814, 1076, "Zeta Puppis is a blue star in the constellation of Puppis.");
            star2.print_description("Suhail Khadar - the brightest roar (Arabic)");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(2000);
            Console.WriteLine("\n------------ Obj3 - Asteroid ------------");
            Asteroid asteroid1 = new Asteroid("Melanholia");
            asteroid1.print_description(); //метод род.кл. переопределен не был
            Console.WriteLine(asteroid1);
            Console.WriteLine("Research asteroid...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(2000);
            Console.WriteLine("...");
            Thread.Sleep(2000);
            Console.WriteLine("Research finished");
            Thread.Sleep(500);
            asteroid1.Legend = "Impact - zero probability. Suitable for ore mining"; //позже можно доработать: данное поле изменяет обект класса - SpaceProbe
            Console.WriteLine(asteroid1);
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(2000);
            Console.WriteLine("\n------------ Obj4 - NeutronStar ------------");
            NeutronStar neutronStar1 = new NeutronStar("Alma Star", 17, 111, 8, 2663568, 168000, "");
            Console.WriteLine(neutronStar1);
            neutronStar1.print_description("SN 1987A was a type II supernova in the Large Magellanic Cloud, a dwarf satellite galaxy of the Milky Way.");

           


        }
    }
}
