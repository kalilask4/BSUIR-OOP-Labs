using System;
using System.Collections.Generic;

namespace OOP_lab9_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo
            //произвести товар (dt = random)
            //принять товар (0t)
            //купить товар (dt = 2sec)
            //списать со склада (0t)
            //проверка наличия товаров (0t)
            //проверка заполненности склада (0t)

            //обекты: склад, производитель(3), товар(*), покупатель(1 условный - method)

            //mess => отгружен
            //        куплен
            //        переучет

            Random random = new Random();
            Warehouse warehouse = new Warehouse(50);
            Console.WriteLine(warehouse);

            List<Good> samples = new List<Good>();//образцы товаров
            Good good1 = new Good("Winchester", 60);
            Good good2 = new Good("Video card", 100);
            Good good3 = new Good("CPU", 20);
      


            //Maker maker1 = new Maker("Gigabite", "Small_scale");
            //Console.WriteLine(maker1.ToString());
            //Maker maker2 = new Maker("AMD", );
            //Console.WriteLine(maker1.ToString());
            //Maker maker3 = new Maker("HP", );
            //Console.WriteLine(maker1.ToString());


        }
    }
}
