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
            Console.WriteLine("\n------------ Obj1 - Sun ------------");
            Star star1 = new Star("Sun", 5778, 1);
            Console.WriteLine(star1.ToString());
            star1.print_description(); //метод род.кл. переопределен
            Console.WriteLine("\n------------ Obj2 - Star ------------");


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


        }
    }
}
