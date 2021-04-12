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
            Spacecraft probe1 = new Spacecraft("Voyager", "planets exploration", 1.2);
            Console.WriteLine(probe1);
            probe1.Move(planet2, planet1);
            probe1.Calc_time(planet2, planet1.Earth_distance);

            Console.WriteLine();
            MannedSpacecraft ship1 = new MannedSpacecraft("Starship", "traveling", 0.7);
            Console.WriteLine(ship1);
            ship1.Move(planet2, planet3);
            ship1.Calc_time(planet2, planet1.Earth_distance);



        }
    }
}
