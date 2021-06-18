using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab7_serialization
{
    sealed class Car
    {
        public string auto_brands;
        public string model;
        private double fuel_tank_capacity;
        private double fuel_quantity;
        private int current_speed;
        private double fuel_consumption;
        private double[] pressure_whells = new double[4];


        //public Car() : this("Noname", "Noname")
        //{
        //}
        //public Car(string auto_brands, string model) : this(auto_brands, model, 0.0, 0.0, 0, 0.0, 0.0, 0.0, 0.0, 0.0)
        //{
        //}

        //public Car(string auto_brands) : this(auto_brands, "", 0.0, 0.0, 0, 0.0, 0.0, 0.0, 0.0, 0.0)
        //{
        //}

        public Car(string auto_brands, string model, double fuel_tank_capacity,
           double fuel_quantity, int current_speed, double fuel_consumption,
           params double[] pressure_whells)
        {
            this.auto_brands = auto_brands;
            Model = model;
            Fuel_tank_capacity = fuel_tank_capacity;
            Fuel_quantity = fuel_quantity;
            Current_speed = current_speed;
            Fuel_consumption = fuel_consumption;
            //Pressure_whells = pressure_whells;
        }

        public string Model { get => model; set => model = value; }

        public double Fuel_tank_capacity { get => fuel_tank_capacity; set => fuel_tank_capacity = value; }
        /*{
            get
            {
                return fuel_tank_capacity;
            }

            set
            {
                if (value >= 0 & value <= 1000)
                    fuel_tank_capacity = value;
            }
        }*/

        public double Fuel_quantity { get => fuel_quantity; set => fuel_quantity = value; }
        /*{
            get
            {
                return fuel_quantity;
            }

            set
            {
                if (value >= 0 & value <= 1000)
                    fuel_quantity = value;
            }
        }*/

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

       /* public double[] Pressure_whells
        {
            get
            {
                return pressure_whells;
            }

            set
            {
                pressure_whells.Initialize();
                int i = 0;
                foreach (double p in value)
                {
                    if (p >= 0 & p <= 4.5)
                        pressure_whells[i] = p;
                    else throw new Exception("Invalid value!");
                    i++;
                    if (i >= 4) break;
                }
            }
        }*/

        public double calc_remainder_mileage()
        {
            return ((this.Fuel_tank_capacity - this.Fuel_quantity) / this.Fuel_consumption);
        }
        /*
        public bool check_wheel_breakdown()
        {
            int i = 0;
            bool is_wheel_breakdown = false;
            foreach (double p in Pressure_whells)
            {
                if (p <= 2)
                {
                    Current_speed = 0;
                    //Console.WriteLine("Current speed {0} {1} has been reset to 0 km/h", this.auto_brands, this.Model);
                    is_wheel_breakdown = true;
                    break;
                }
                else
                {
                    //Console.WriteLine("Whell's pressure is ok. Currenе speed {0} {1} is {2} km/h", this.auto_brands, this.Model, this.Current_speed);
                }
                i++;
                if (i >= 4) break;
            }
            if (is_wheel_breakdown)
                Console.WriteLine("Checking {0} {1}. Whell pressure isn't ok. Current speed has been reset to {2} km/h", this.auto_brands, this.Model, this.Current_speed);
            else
                Console.WriteLine("Checking {0} {1}. Whell pressure is ok. Currenе speed is {2} km/h", this.auto_brands, this.Model, this.Current_speed);
            return is_wheel_breakdown;
        }
        */
        

        //метод, определяющий более быстрый автомобиль из двух(возвращает true, если скорость текущего авто выше)
        public bool is_car_faster(Car car2)
        {
            if (this.Current_speed > car2.Current_speed)
                return true;
            else
                return false;
        }

        /*public static Car search_the_fastest_car(Car car1, Car car2, Car car3)
        {
            if (car1.Current_speed > car2.Current_speed & car1.Current_speed > car3.Current_speed)
                return car1;
            if (car2.Current_speed > car3.Current_speed)
                return car2;
            return car3;
        }*/


        public override string ToString()
        {
            //return base.ToString();
            return String.Format("The car make is {0}, model is {1}\n" +
                "fuel tank capacity is {2} L \n" +
                "fuel quantity is {3} L \n" +
                "current_speed is {4} km/h\n" +
                "fuel_consumption is {5} L/100km\n" +
                "pressure_whell is {6} - {7} - {8} - {9} Bar\n",
                auto_brands, Model, Fuel_tank_capacity, Fuel_quantity, Current_speed, Fuel_consumption
               /* Pressure_whells[0], Pressure_whells[1], Pressure_whells[2], Pressure_whells[3]*/);
        }


        public static void SaveClass(string filename)
        {
            Type t = typeof(Car);
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine($"Полное имя класса: {t.FullName}");
            if (t.IsAbstract) writer.WriteLine("Абстрактный класс");
            if (t.IsClass) writer.WriteLine("Обычный класс");
            if (t.IsInterface) writer.WriteLine("Интерфейс");
            if (t.IsEnum) writer.WriteLine("Перечисление");
            if (t.IsSealed) writer.WriteLine("Закрытый для наследования");
            FieldInfo[] fields = t.GetFields();
            if (fields.Length > 0)
                writer.WriteLine("***Поля класса***");
            foreach (var field in fields)
            {
                writer.WriteLine(field);
            }
            PropertyInfo[] properties = t.GetProperties();
            if (properties.Length > 0)
                writer.WriteLine("***Свойства класса***");
            foreach (var property in properties)
            {
                writer.WriteLine(property);
            }
            MethodInfo[] methods = t.GetMethods();
            if (methods.Length > 0)
                writer.WriteLine("***Методы класса***");
            foreach (var method in methods)
            {
                writer.WriteLine(method);
            }
            writer.Close();
        }

    }
}
