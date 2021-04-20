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
            Planet planet4 = new Planet("Saturn", 10.7, "Beautiful planet", "Sun");
            Console.WriteLine(planet4);
            MannedSpacecraft ship2 = new MannedSpacecraft("Rise", "traveling", 3.7);
            Console.WriteLine(ship2);
            ship2.Move(planet2, planet4);

            //Gluing
            ship2.Calc_time(planet2, planet4.Earth_distance);
            //Casting
            ((IPromote)ship2).Calc_time(planet2, planet4.Earth_distance);
            ((IMoving)ship2).Calc_time(planet2, planet4.Earth_distance);
            //Wrapping
            ship2.MSpacecraftIPromoteCalc_time(planet2, planet4.Earth_distance);
            ship2.MSpacecraftIMovingCalc_time(planet2, planet4.Earth_distance);

            //Метод изменяющий поля обекта
            Console.WriteLine("Count tickets: " + planet4.Count_tickets);
            planet4.Sell(1);
            Console.WriteLine("Count tickets: " + planet4.Count_tickets);
            planet4.Sell(5);
            Console.WriteLine("Count tickets: " + planet4.Count_tickets);

            Console.WriteLine("------------------------------------------------------------");
            IMoving[] astronomicalobjects = new IMoving[4]
            {
                new MannedSpacecraft("Theseus", "exploration Rorschach", 5.7),
                new Spacecraft("Big deal", "planets exploration", 1.5),
                new MannedSpacecraft("Shore", "delivery", 1.1),
                new Spacecraft("Maelstrom", "planets exploration", 1.01)               
            };

            foreach (IMoving obj in astronomicalobjects)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------------------------");
                foreach (IMoving obj in astronomicalobjects)
                {
                if (obj is IPromote)
                {
                    Console.WriteLine(obj);
                    (obj as IPromote)?.Calc_time(planet2, planet4.Earth_distance);
                }
            }

            //test compare
            //Console.WriteLine(((Spacecraft)astronomicalobjects[1]).Name.CompareTo(((Spacecraft)astronomicalobjects[2]).Name));
            
            Console.WriteLine("------Before sort-----");
            foreach (IMoving obj in astronomicalobjects)
            {
                Console.WriteLine(((Spacecraft)obj).Name);
            }
            
            Array.Sort(astronomicalobjects);
            Console.WriteLine("------After sort-----");
            foreach (IMoving obj in astronomicalobjects)
            {
                Console.WriteLine(((Spacecraft)obj).Name);
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("------Before sort whith Comarer-----");
            
            Planet[] planets = new Planet[4]
            {
                planet1,
                planet2,
                planet4,
                planet3
            };

            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("------After sort whith Comarer (by Earth_distance)-----");
            Array.Sort(planets, new ComarerPlanetByEarth_distance());
            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("------After sort whith Comarer (by Name)-----");
            Array.Sort(planets, new ComarerPlanetByName());
            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet);
            }

        }
    }
}
