using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab7_serialization
{
   [Serializable]
    sealed class Car
    {
        public string auto_brands;
        public string model;
        private double fuel_tank_capacity;
        private double fuel_quantity;
        private int current_speed;
        private double fuel_consumption;

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

        public void SaveObject(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(auto_brands);
            bw.Write(model);
            bw.Write(fuel_tank_capacity);
            bw.Write(fuel_quantity);
            bw.Write(current_speed);
            bw.Write(fuel_consumption);
            fs.Close();
            Console.WriteLine($"Файл {filename} сохранен");
        }

        public static Car LoadObject(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            string auto_brands = br.ReadString();
            string model = br.ReadString();
            double fuel_tank_capacity = br.ReadDouble();
            double fuel_quantity = br.ReadDouble();
            int current_speed = br.ReadInt32();
            double fuel_consumption = br.ReadDouble();
            fs.Close();
            Console.WriteLine($"Файл {filename} считан");
            return new Car(auto_brands, model, fuel_tank_capacity, fuel_quantity, current_speed, fuel_consumption);
        }


        public void Serialize(string filename)
        {
            Stream s = new FileStream(filename, FileMode.Create);
            BinaryFormatter fmt = new BinaryFormatter();
            fmt.Serialize(s, this);
            s.Close();
            Console.WriteLine($"Объект сериализован");
        }

        public static Car Deserialize(string filename)
        {
            Stream s = new FileStream(filename, FileMode.Open);
            BinaryFormatter fmt = new BinaryFormatter();
            Car car = (Car)fmt.Deserialize(s);
            s.Close();
            Console.WriteLine($"Объект десериализован");
            return car;
        }

    }
}
