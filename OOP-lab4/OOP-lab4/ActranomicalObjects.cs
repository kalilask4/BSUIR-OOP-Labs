using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba4
{
    class AstronomicalObject
    {
        string name="Noname";
        double earth_mass;    // относительно земли 1 M⊕ = (5,9722 ± 0,0006) × 1024 кг
        double earth_distance;    //расстояние до земли в парсеках 1пс=3,2 св.года
        double temperature_K; //средняя температура в Кельвинах
        string legend = "Unsafe for humans.";



        public string Name { get => name; set => name = value; }
        public double Earth_mass { get => earth_mass; set => earth_mass = value; }
        public double Earth_distance { get => earth_distance; set => earth_distance = value; }
        public double Temperature_K { get => temperature_K; set => temperature_K = value; }
        public string Legend { get => legend; set => legend = value; }

        public AstronomicalObject()
        {
        }

        protected AstronomicalObject(string name, double earth_mass, double earth_distance, double temperature_K, string legend)
        {
            Name = name;
            Earth_mass = earth_mass;
            Earth_distance = earth_distance;
            Temperature_K = temperature_K;
            Legend = legend;
        }

        public void print_description()
        {
            Console.WriteLine($"Astronomical object {name}.");
        }

        public double calculate_base_pathtime() //расчет времени пути до земли. Базовая скорость из константы BASESPEED
        {
            return 0;
        }

        public double advance()
        {
            return 0;
        }

    }
}
