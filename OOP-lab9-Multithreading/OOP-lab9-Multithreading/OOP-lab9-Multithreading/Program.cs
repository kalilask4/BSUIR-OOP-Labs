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
            List<Good> goods = new List<Good>();
            Warehouse warehouse = new Warehouse(50, goods);
            Console.WriteLine(warehouse);

            List<Good> samples = new List<Good>();//образцы товаров
            Good sample_good1 = new Good("Winchester", 6);
            Good sample_good2 = new Good("Video card", 10);
            Good sample_good3 = new Good("CPU", 2);
            samples.Add(sample_good1);
            samples.Add(sample_good2);
            samples.Add(sample_good3);
      
            foreach (Good good in samples){
                Console.WriteLine(good.ToString());
            }

            Maker maker1 = new Maker("Gigabite", 7);
            Maker maker2 = new Maker("AMD", 3);
            Maker maker3 = new Maker("HP", 2);

            goods.Add(maker1.makeGood(sample_good1, "SSD AI-34.2"));
            goods.Add(maker2.makeGood(sample_good2, "ARKI-X 2.2"));

            //Maker maker1 = new Maker("Gigabite", "Small_scale");
            //Console.WriteLine(maker1.ToString());
            //Maker maker2 = new Maker("AMD", );
            //Console.WriteLine(maker1.ToString());
            //Maker maker3 = new Maker("HP", );
            //Console.WriteLine(maker1.ToString());


        }
    }
}
