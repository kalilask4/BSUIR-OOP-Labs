using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lab9_Multithreading
{
    class Warehouse
    {
        public string name = "Warehouse Socket";
        public static int capacity;        //доработать. инкапсуляция!
        public static bool isopen=true;    //доработать. инкапсуляция!
        List<Good> goods;
       

        public int Capasity
        {
            get => capacity;
            set
            {
                if (value == 20 || value == 50 || value == 100 || value == 10 || value == 5)
                {
                    capacity = value;
                }
                else
                {
                    new Exception("Неверный размер склада (возможные варианты: 10, 20, 50, 100, 5");
                }
            }
        }

        public Warehouse(int capasity, List<Good> goods)
        {
            Capasity = capasity;
            this.goods = goods;
        }

        public void addGood(Good good)
        {
            goods.Add(good);
            Console.WriteLine($"<= {good.name}, {good.model} от производителя {good.maker.Name} доставлен на склад");
        }

        public bool checkGoodsWarehouse()
        {
            return this.goods.Count>0;
        }

        public static bool checkWarehouseIsOpen()
        {
            if (!Warehouse.isopen)
            {
                //Console.WriteLine("Склад закрыт.");
            }
            return Warehouse.isopen;
        }

        public void showGoods()
        {
            Console.WriteLine("Все тоавры на складе:");
            foreach (Good good in goods)
            {
                Console.WriteLine(good);
            }
        }

        public void marketing()
        {
            Thread.Sleep(1000);
            Console.WriteLine("--Начаты покупки--");
            
            while (true)
            {
                Random random = new Random();
                if (!checkGoodsWarehouse())
                {
                    Console.WriteLine("Переучет.");
                    Warehouse.isopen = false;
                    Console.WriteLine("Покупки прекращены - склад закрыт.");
                    break;
                }

                lock (goods) ;
                var item = goods.OrderBy(s => random.NextDouble()).First();
                Console.Write($"=> Куплен {item.ToString()}. "); 
                goods.Remove(item);
                Console.WriteLine($"На складе осталось {goods.Count} товаров. ");
                Thread.Sleep(2000);

               /* int index = random.Next(goods.Count);
                Console.WriteLine($"=> Куплен {index}{goods[index]}"); ;
                goods.RemoveAt(index);
                Console.WriteLine($"На складе {goods.Count} товаров");
                Thread.Sleep(2000);*/
            }
        }

        public override string ToString()
        {
            return $"{name}, вместимость {Capasity} ед.";
        }
    }
}
