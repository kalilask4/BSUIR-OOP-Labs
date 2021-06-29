using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                if (value == 50 || value == 70 || value == 100 || value == 200)
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

        public void showGoods()
        {
            foreach (Good good in goods)
            {
                Console.WriteLine(good.name);
            }

        }

        public override string ToString()
        {
            return $"{name}, вместимость {Capasity} ед.";
        }
    }
}
