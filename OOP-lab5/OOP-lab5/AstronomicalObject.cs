using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    abstract class AstronomicalObject
    {
        public string name = "Noname";
        public string type_object = "Indefinite";
        public string legend = "Unsafe for humans.";

        public string Name { get => name; set => name = value; }
        public string Type_object { get => type_object; set => type_object = value; }       
        public string Legend { get => legend; set => legend = value; }

        public AstronomicalObject()
        {
        }

        protected AstronomicalObject(string name, string legend)
        {
            Name = name;          
            Legend = legend;
        }
        /*
       
        public double calculate_base_pathtime() //доработать, если буду работать с этой прогой: расчет времени пути до земли (базовая скорость из константы BASESPEED)
        {
            return 0;
        }*/

 
        public override string ToString()
        {
            return "Object name: " + Name + ". Object type: " + Type_object + ". " + Legend;
        }
    }

}
