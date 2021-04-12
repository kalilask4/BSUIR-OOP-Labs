using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class Driver
    {
        public string Name { get; set; }
        public Car car { get; set; }

        public Driver(string name)
        {
            Name = name;
        }


        public static List<Car> CheckFaults(Car[] cars)
        {
            var list = new List<Car>(cars);
            String str = "";
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].engine.is_varning)
                {
                    //Console.WriteLine( $"Авто {list[i].Number} требуестя диагностика двигателя {list[i].engine.Vin}.\n");
                    //  Console.WriteLine(str);
                }
                else
                {
                    str = $"Авто {list[i].Number} диагностика не требуестя.\n";
                    list.Remove(list[i]);
                    //Console.WriteLine(str);


                }

            }

            return list;
        }

    }
}

