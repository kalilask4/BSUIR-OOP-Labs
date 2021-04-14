using System;

namespace OOP_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     ....................................");
            Console.WriteLine("\n     .    Welcome to Space observer!    . ");
            Console.WriteLine("     ....................................\n");

            Planet planet1 = new Planet("Draugr", 2300, "The lightest exoplanet (less than 0.0004 Earth)", "PSR B1257+12");
            Console.WriteLine(planet1);
            Planet planet2 = new Planet("Earth", 0, "Blue planet", "Sun");
            Console.WriteLine(planet2);
            Planet planet3 = new Planet("Dimidium", 50, "Hot Jupiter", "51 Pegasi");
            Console.WriteLine(planet3);
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------"); 
            Spacecraft probe1 = new Spacecraft("Voyager", "planets exploration", 1.2);
            Console.WriteLine(probe1);
            probe1.Move(planet2, planet1);
            probe1.Calc_time(planet2, planet1.Earth_distance);
            Console.WriteLine();
            
            Console.WriteLine("------------------------------------------------------------");           
            MannedSpacecraft ship1 = new MannedSpacecraft("Starship", "traveling", 0.7);
            Console.WriteLine(ship1);
            ship1.Move(planet2, planet3);
            ship1.Calc_time(planet2, planet1.Earth_distance);
            Console.WriteLine();
            
            Console.WriteLine("------------------------------------------------------------");
            //Тест работы объекта, переданного по ссылке в родительский
            Spacecraft shuttle1 = new MannedSpacecraft("Hope", "delivery", 1.1);
            Console.WriteLine(shuttle1); //ToString из дочернего - as MannedSpacecraft (child)
            Console.WriteLine(shuttle1.Type_object); //Свойство Type_object из базового - Spacecraft (base)
            shuttle1.Move(planet3, planet2); //Move из базового - as a Spacecraft (base)
            shuttle1.Calc_time(planet3, planet2.Earth_distance); //Calc_time из дочернего (был переопределен - as MannedSpacecraft (child)
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------");



        }
    }
}
