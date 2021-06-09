using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba6
{
    abstract class AstronomicalObject:IComparable
    {
        public string name = "Noname";
        public string type_object = "Indefinite";
        public double earth_mass;    // относительно Земли 1 M⊕ = (5,9722 ± 0,0006) × 1024 кг
        public double sun_mass=1;   //относительно массы Солнца
        public double earth_distance;    //расстояние до земли св.л (1пс=3,2 св.года), max=13,035 млрд. св.л.
        public string legend = "Unsafe for humans.";

        public string Name { get => name; set => name = value; }
        public string Type_object { get => type_object; set => type_object = value; }
        public double Earth_mass { get => earth_mass; set => earth_mass = value; }
        public virtual double Sun_mass { get => sun_mass; set => sun_mass = value; }
        public double Earth_distance { get => earth_distance; set => earth_distance = value; }
        public string Legend { get => legend; set => legend = value; }

        public AstronomicalObject()
        {
        }

        protected AstronomicalObject(string name, double earth_mass, double earth_distance, string legend)
        {
            Name = name;
            Earth_mass = earth_mass;
            Earth_distance = earth_distance;
            Legend = legend;
        }

        protected AstronomicalObject(string name)
        {
            Name = name;
        }

        public virtual void print_description(string additional_description="")
        {
            Console.WriteLine("An astronomical object or celestial object \n" +
            "is a naturally occurring physical entity, association, or structure \n" + 
            "that exists in the observable universe." + additional_description);
            
        }        

        public double calculate_base_pathtime() 
        {
            return 0;
        }

        public override string ToString()
        {
            return "Object name: " + Name + ". Object type: " + Type_object + ". " + Legend;
        }

        public int CompareTo(object obj)
        {
            return this.sun_mass.CompareTo((double)((AstronomicalObject)obj).sun_mass);
        }

        public override bool Equals(object obj)
        {
            return ((obj as AstronomicalObject).name ?? "") == name;
        }
    }
}
