using OOP_lab6_param_coll;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab6_param_coll
{
    class NeutronStar: Star, IGlowing
    {
        private double sun_mass_before_explosion;

        public virtual double Sun_mass_before_explosion { 
            get => sun_mass_before_explosion;
            set
            {
                if (value > 8 & value < 40)
                    sun_mass_before_explosion = value;
            }
            }

        public NeutronStar(string name,double sun_mass_before_explosion, double temperature_K, 
                           double sun_mass, double earth_mass, double earth_distance, string legend)
    : base( name, temperature_K, sun_mass, earth_mass, earth_distance, legend)
        {
            Type_object = "Neutron Star";
            Sun_mass_before_explosion = sun_mass_before_explosion;
        }

        public NeutronStar(string name, double temperature_K, double sun_mass)
        {
            Name = name;
            Type_object = "Neutron Star";
            Temperature_K = temperature_K;
            Sun_mass = sun_mass;
        }

        public override void print_description(string additional_description = "")
        {
            Console.WriteLine("A neutron star is the collapsed core of a massive supergiant star, \n" +
                "which had a total mass of between 10 and 25 solar masses. \n" + additional_description);
        }

        public void Glove()
        {
            Console.WriteLine("        ");
            Console.WriteLine("        ");
            Console.WriteLine("        *");
            Console.WriteLine("   **   *    **");
            Console.WriteLine(" **     .      **");
            Console.WriteLine("**     ***      ** ");
            Console.WriteLine("**    *****     **");
            Console.WriteLine("**     ***      **");
            Console.WriteLine(" **     .      **");
            Console.WriteLine("   **   *    **");
            Console.WriteLine("        *");
            Console.WriteLine("        ");
            Console.WriteLine("        ");
        }                     
    }
}
