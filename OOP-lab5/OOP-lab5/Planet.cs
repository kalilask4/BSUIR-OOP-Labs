using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    class Planet : AstronomicalObject, IPromote
    {
               
        private double earth_distance;    //расстояние до земли св.л (1пс=3,2 св.года), max=13,035 млрд. св.л.
        string star;
        int count_tickets = 3;
        
        
        public double Earth_distance { get => earth_distance; set => earth_distance = value; }
        public int Count_tickets { get => count_tickets; set => count_tickets = value; }


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


        public void Sell(int count_tickets)
        {
            if (count_tickets<=this.count_tickets)
            {
                Random rnd = new Random(2453434);
                int value = rnd.Next();
                this.count_tickets -= count_tickets;
                Console.WriteLine("Booked successfully. You turn: " + value);
            }
            else
            {
                Console.WriteLine("Unfortunately we only have " + this.count_tickets + " ticket(s)");
            }
        }


        public void Calc_time(Planet a, double path)
        {
            Console.WriteLine("(IPromote) Add: Choose our's trip! It takes " + path);
        }


        public override string ToString()
        {
            return  this.Type_object + " name: " + Name + ". Star - " + Star + ". "+ Legend;
        }
    }
}
