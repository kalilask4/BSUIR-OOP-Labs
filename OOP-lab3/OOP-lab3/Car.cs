using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class Car
    {
        public string Number { get; set; }
        public string Vin { get; set; } //Vehicle Identification Number

        public Station station = null;
        public Engine engine;
        public Driver driver;

        public Car(string number, string vin)
        {
            Number = number;
            Vin = vin;
            engine = new Engine(vin, this);
        }

        public Car(string number, string vin, Station station, Driver driver) : this(number, vin)
        {
            this.station = station;
            this.driver = driver;
        }

        public Car()
        {
        }
    }
}
