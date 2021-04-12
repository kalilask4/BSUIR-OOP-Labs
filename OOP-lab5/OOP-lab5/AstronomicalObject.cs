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




    }

}
