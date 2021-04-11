using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba4
{
    abstract class AstronomicalObject
    {
        public string name = "Noname";
        public string type_object = "Indefinite";
        public double earth_mass;    // относительно земли 1 M⊕ = (5,9722 ± 0,0006) × 1024 кг
        public double sun_mass;    // относительно земли 1 M⊕ = (5,9722 ± 0,0006) × 1024 кг
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

        protected AstronomicalObject(string name, double earth_mass, double earth_distance, double temperature_K, string legend)
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

        public virtual void print_description()
        {
            Console.WriteLine("An astronomical object or celestial object " +
            "is a naturally occurring physical entity, association, or structure " + 
            "that exists in the observable universe.");
            
        }        

        public double calculate_base_pathtime() //расчет времени пути до земли. Базовая скорость из константы BASESPEED
        {
            return 0;
        }

        abstract public double ad(); //рекламный слоган

        public override string ToString()
        {
            return "Object name: " + Name + ". Object type: " + Type_object + ". " + Legend;
        }
    }
}
