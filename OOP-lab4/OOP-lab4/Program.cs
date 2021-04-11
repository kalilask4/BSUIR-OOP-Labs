using OOPlaba4;
using System;

namespace OOP_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Space!");
            AstronomicalObject a0; //объект абстрактного класса создавать нельзя, но можно создать ссылку, в которую можно будет положить наследника
            //AstronomicalObject a1 = new AstronomicalObject(); 
            //Console.WriteLine(a1.Name);
            //Console.WriteLine(a1);
            Console.WriteLine("------------ Obj1 - Sun ------------");
            Star star1 = new Star("Sun", 5778, 1);
            Console.WriteLine(star1.ToString());
            star1.print_description();
        }
    }
}
