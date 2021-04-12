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

            Spacecraft probe1 = new Spacecraft("Voyager", "Planets exploration", 1.2);
            Console.WriteLine(probe1);
            probe1.move(planet2, planet1);
            probe1.calc_time(planet2, planet1.Earth_distance);



        }
    }
}
