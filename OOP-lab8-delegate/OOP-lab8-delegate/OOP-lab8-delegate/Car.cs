using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab8_delegate
{
    public delegate void DELVOID();
    class Car
    {
        public string auto_brands;
        public string model;
        private double fuel_tank_capacity;
        private double fuel_quantity;
        private int current_speed;
        private double fuel_consumption;
        private DELVOID delvoid;   // must be private!


        public Car(string auto_brands, string model, double fuel_tank_capacity,
           double fuel_quantity, int current_speed, double fuel_consumption
           )
        {
            this.auto_brands = auto_brands;
            Model = model;
            Fuel_tank_capacity = fuel_tank_capacity;
            Fuel_quantity = fuel_quantity;
            Current_speed = current_speed;
            Fuel_consumption = fuel_consumption;

        }

        public string Model { get => model; set => model = value; }

        public double Fuel_tank_capacity { get => fuel_tank_capacity; set => fuel_tank_capacity = value; }

        public double Fuel_quantity { get => fuel_quantity; set => fuel_quantity = value; }


        public int Current_speed
        {
            get
            {
                return current_speed;
            }

            set
            {
                if (value >= 0 & value <= 447)
                    current_speed = value;
            }
        }

        public double Fuel_consumption
        {
            get
            {
                return fuel_consumption;
            }

            set
            {
                if (value >= 0 & value <= 40)
                    fuel_consumption = value;
            }
        }


        public void addDelvoid(DELVOID d)
        {
                delvoid += d;
        }


        public void runDelvoid()
        {
            delvoid.Invoke();
        }

        public bool comparison(Car car)
        {
            return delvoid == car.delvoid;
        }


        public double calc_remainder_mileage()
        {
            return ((this.Fuel_tank_capacity - this.Fuel_quantity) / this.Fuel_consumption);
        }

        //метод, определяющий более быстрый автомобиль из двух(возвращает true, если скорость текущего авто выше)
        public bool is_car_faster(Car car2)
        {
            if (this.Current_speed > car2.Current_speed)
                return true;
            else
                return false;
        }


        public override string ToString()
        {
            //return base.ToString();
            return String.Format("The car make is {0}, model is {1}\n" +
                "fuel tank capacity is {2} L \n" +
                "fuel quantity is {3} L \n" +
                "current_speed is {4} km/h\n" +
                "fuel_consumption is {5} L/100km\n",
                auto_brands, Model, Fuel_tank_capacity, Fuel_quantity, Current_speed, Fuel_consumption
               );
        }
    }
}
