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
        private int capacity;
        List<Good> goods;
       

        public int Capasity
        {
            get => capacity;
            set
            {
                if (value == 50 || value == 70 || value == 100 || value == 200 || value == 10)
                {
                    capacity = value;
                }
                else
                {
                    new Exception("Неверный размер склада (возможные варианты: 50, 70, 100, 200");
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

        public bool checkWarehouse()
        {
            return this.goods.Count>0;
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
            Thread.Sleep(3000);
            Console.WriteLine("Начаты покупки");
            
            while (true)
            {
                Random random = new Random();
                if (!checkWarehouse())
                    break;

                int index = random.Next(goods.Count);
                Console.WriteLine($"Куплен {goods[index]}"); ;
                goods.RemoveAt(index);
                Thread.Sleep(2000);
            }
        }


        public override string ToString()
        {
            return $"{name}, вместимость {Capasity} ед.";
        }
    }
}
