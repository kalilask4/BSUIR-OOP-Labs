using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab4
{
    class NeutronStar: Star
    {
        private double sun_mass_before_explosion;

        public virtual double Sun_mass_beforee_xplosion { 
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
            Type_object = "NeutronStar";
            Sun_mass_beforee_xplosion = sun_mass_before_explosion;
        }

        public override void print_description(string additional_description = "")
        {
            Console.WriteLine("A neutron star is the collapsed core of a massive supergiant star, " +
                "which had a total mass of between 10 and 25 solar masses. " + additional_description);
        }

    }
}
