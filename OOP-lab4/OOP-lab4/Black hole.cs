using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab4
{
    sealed class Blackhole : Star //закрытый для наследования
    {
        private double sun_mass_before_explosion;

        public double Sun_mass_before_explosion
        {
            get => sun_mass_before_explosion;
            set
            {
                if (value > 40)
                    sun_mass_before_explosion = value;
            }
        }

        public Blackhole(string name, double sun_mass_before_explosion, double temperature_K,
                           double sun_mass, double earth_mass, double earth_distance, string legend)
    : base(name, temperature_K, sun_mass, earth_mass, earth_distance, legend)
        {
            Type_object = "Black hole";
            Sun_mass_before_explosion = sun_mass_before_explosion;
        }

        public override void print_description(string additional_description = "")
        {
            Console.WriteLine("A black hole is a region of spacetime where gravity is so strong " +
                "that nothing—no particles or even electromagnetic radiation such as light—can escape from it. " +
                additional_description);
        }
    
    }
}
