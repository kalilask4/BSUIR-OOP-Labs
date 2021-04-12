using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class Station
    {
        public string Name { get; set; }
        public string Address = "emptyAddress";// { get; set; }
        public int Capasity { get; set; }
        public Car[] cars;
       

        public Station()//string name, string address, int capasity)
        {
            Name = "NonameStation";
            Capasity = 1;
            cars = new Car[Capasity];
    }

        public Station(string name)
        {
            Name = name;
            Capasity = 1;
            cars = new Car[Capasity];
        }
        public Station(string name, int capasity)
        {
            Name = name;
            Capasity = capasity;
            cars = new Car[Capasity];
        }
        public Station(string name, int capasity, string address)
        {
            Name = name;
            Capasity = capasity;
            cars = new Car[Capasity];
            Address = address;
        }

        public Station(int capasity): this()
        {
            Capasity = capasity;
            cars = new Car[Capasity];
        }

        

        int calculate_workload(Car[] cars)
        {
            int workload = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null)
                    workload += 1;
            }

            return workload;
        }

        public override string ToString()
        {
            int workload = calculate_workload(cars);
           
            string str = $"Станция технического обслуживания {Name}. Загруженность - {workload}/{Capasity} авто:\n";
            if (workload < Capasity)
            {

                str += "Примет авто на диагностику.";
                if (Address != "emptyAddress")
                {
                    str += $" Наш адрес: {Address}.";
                }

            }
            else
            {
                str += $" загружена:\n ";
                foreach (Car car in this.cars)
                {
                    str += $"{car.Number}\n";
                }
            }
               

            return str;
        }
    }
}
