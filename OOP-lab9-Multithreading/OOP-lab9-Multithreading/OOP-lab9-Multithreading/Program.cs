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
            Queue<Good> goods_queue = new Queue<Good>();
            List<Good> goods = new List<Good>();
            
            Warehouse warehouse = new Warehouse(10, goods);
            Console.WriteLine(warehouse);
            Console.WriteLine();

            List<Good> samples = new List<Good>();//образцы товаров
            Good sample_good1 = new Good("HDD", 6);
            Good sample_good2 = new Good("SDD", 10);
            Good sample_good3 = new Good("CPU", 2);
            Good sample_good4 = new Good("Cooler", 2);
            Good sample_good5 = new Good("RAM", 2);
            samples.Add(sample_good1);
            samples.Add(sample_good2);
            samples.Add(sample_good3);
            samples.Add(sample_good4);
            samples.Add(sample_good5);
      
            /*foreach (Good good in samples){
                Console.WriteLine(good.ToString());
            }*/

            Maker maker1 = new Maker("Gigabite", 7, samples, goods);
            Maker maker2 = new Maker("AMD", 3, samples, goods);
            Maker maker3 = new Maker("HP", 2, samples, goods);
            List<Maker> makers = new List<Maker>();
            makers.Add(maker1); 
            makers.Add(maker2); 
            makers.Add(maker3);

            maker1.makeGood(sample_good1, "SSD AI-34.2");

            maker1.startProduction(warehouse);
            maker2.startProduction(warehouse);
            maker3.startProduction(warehouse);


            //maker1.show();
            //maker2.show();
            Console.WriteLine();
            warehouse.showGoods();

            warehouse.marketing();



            //goods.Add(maker1.makeGood(sample_good1, "SSD AI-34.2"));
            //goods.Add(maker2.makeGood(sample_good2, "ARKI-X 2.2"));

            //Maker maker1 = new Maker("Gigabite", "Small_scale");
            //Console.WriteLine(maker1.ToString());
            //Maker maker2 = new Maker("AMD", );
            //Console.WriteLine(maker1.ToString());
            //Maker maker3 = new Maker("HP", );
            //Console.WriteLine(maker1.ToString());

            /* static void startProduction()
             {
                 maker1.makeGood(sample_good1, "SSD AI-34.2")

             }*/

             
            Console.ReadKey();
        }
    }
}
