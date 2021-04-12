using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class Engine
    {
        public string Vin { get; set; } //Vehicle Identification Number
        Car car;
        public string Message = "";
        public bool is_varning = false;

        public Engine(string vin, Car car)
        {
            Vin = vin;
            Message = random_mess();
            is_varning = Message=="" ? (false) : (true);
            this.car = car;
        }


        public static string random_mess()
        {
            String str = "";
            Random rnd = new Random();
            int value = rnd.Next(0, 2); //0 - На приборной панели - Проверьте двигатель
            if (value == 0)
            {
                str = "Check engine!";
            }
            return str;
        }
    }
}
