using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    //реализует 1 интерфейс - Ipromote
    class Planet : AstronomicalObject
    {
               
        private double earth_distance;    //расстояние до земли св.л (1пс=3,2 св.года), max=13,035 млрд. св.л.
        string star;
        public double Earth_distance { get => earth_distance; set => earth_distance = value; }


        public string Star
        {
            get { return star; }
            set
            {
                if (value != "")
                    star = value;
            }
        }

        public Planet()
        {
            type_object = "Planet";
        }

        public Planet(string name, double earth_distance, string legend, string star) : base(name, legend)
        {
            type_object = "Planet";
            Earth_distance = earth_distance;
            Star = star;
        }


        public override string ToString()
        {
            return "Object name: " + Name + ". Object type: " + Type_object + ". " + "Star - " + Star + ". "+ Legend;
        }


    }
}
