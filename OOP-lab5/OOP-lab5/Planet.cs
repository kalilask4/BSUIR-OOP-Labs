using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    class Planet : AstronomicalObject, IPromote
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
            Type_object = "Planet";
        }

        public Planet(string name, double earth_distance, string legend, string star) : base(name, legend)
        {
            Type_object = "Planet";
            Earth_distance = earth_distance;
            Star = star;
        }


        public void Sell()
        {
            throw new NotImplementedException();
        }

        public void Calc_time(Planet a, double path)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return  this.Type_object + " name: " + Name + ". Star - " + Star + ". "+ Legend;
        }

    }
}
