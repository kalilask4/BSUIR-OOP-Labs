﻿using OOPlaba4;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab4
{
    class Star : AstronomicalObject
    {
        public double temperature_K; //средняя температура в Кельвинах
         
        public double Temperature_K { get => temperature_K; set => temperature_K = value; }

        public override double Sun_mass //свойство переопределено, в классе-родителе данное поле - virtual
        { 
            get { return base.Sun_mass;  } 
            set
            {
                if (value > 0.07 & value <= 315) 
                    sun_mass = value;

            }
        }

        public Star(): base()
        {
            Type_object = "Star";
        }

        public Star(string name, double temperature_K, double sun_mass): base(name)
        {
            Type_object = "Star";
            Temperature_K = temperature_K;
            Sun_mass = sun_mass;
        }

        public override double ad()
        {
            throw new NotImplementedException();
        }

        public override void print_description() //переопределение метода, у класса Asteroid не будет переопределен
        {

            Console.WriteLine("An astronomical object consisting of a luminous spheroid of plasma held own gravity.\n" +
                Type_object + " " + Name + " has temperature " + Temperature_K
                + " K. " ); 
        }
    }
}
