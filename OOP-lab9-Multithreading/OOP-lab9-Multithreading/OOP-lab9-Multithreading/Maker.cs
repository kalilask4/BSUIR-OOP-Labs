using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lab9_Multithreading
{
    class Maker
    {
        private string name; //hp, gigabite, amd
        List<Good> sample_goods; //список товаров, которые данный производитель может производить
        double time_coef=1; 
        Random random = new Random();
        List<Good> goods = new List<Good>();


        //public enum SCALE { Unit = 100, SmallScale = 40, MediumScale = 20, BigScale = 10, Mass = 1, };//чем выше масштаб производства, тем быстрее производиться тот или иной товар
        //(здесь коэффициент - для расчета времени производства от базового))
        //свыше 40 — единичное производство;
        //от 20 до 40 вкл. — мелкосерийное производство;
        //от 10 до 20 вкл. — среднесерийное производство;
        //от 1 до 10 вкл. — крупносерийное производство;
        //равный 1 — массовое производство.

        public string Name { get => name; set => name = value; }
        //public SCALE sCALE { get; set; }
        /*public Maker(string name, SCALE sCALE)
        {
            this.name = name;
            this.sCALE = sCALE;
        }*/


        public Maker(string name, double time_coef, List<Good> sample_goods, List<Good> goods)
        {
            this.name = name;
            this.time_coef = time_coef;
            this.sample_goods = sample_goods;
            this.goods = goods;
        }

       /* public Maker(string name, double time_coef, List<Good> sample_goods)
        {
            this.name = name;
            this.time_coef = time_coef;
            this.sample_goods = sample_goods;
        }*/

        public void makeGood(Good sample_good, string model)
        {
            Thread.Sleep((int)(this.time_coef * sample_good.base_produce_time) * 100);//время производства коэф. производителя * коэф. продукта
            Good good = new Good(sample_good, this, model);
            Console.WriteLine($"...произведен {good.name}");
            goods.Add(good);
        }

        public void startProduction()
        {
            while (Warehouse.isopen)
            {
                if (goods.Count < Warehouse.capacity & Warehouse.isopen)//warehouse.Capasity)
                {
                    if (Warehouse.checkWarehouseIsOpen())
                    {

                    
                    Good sample_good = this.sample_goods[random.Next(sample_goods.Count)];
                    Thread.Sleep((int)(this.time_coef * sample_good.base_produce_time * 100));//время производства коэф. производителя * коэф. продукта
                    Good good = new Good(sample_good, this, "mx-" + DateTime.Now.Second);
                    goods.Add(good);
                    Console.WriteLine($"<... Компанией {this.Name} произведен {good.name}.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    
                        Console.WriteLine($"Склад заполнен. Производство на {this.Name} приостановлено.");
                    Thread.Sleep(18000);  //18 с - хорошее время для демонстрации при вместимости 5 - успевают раскупить
                    if (Warehouse.checkWarehouseIsOpen())
                    {
                        Console.WriteLine($"Производство на {this.Name} возобновлено.");
                   
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Производство на {this.Name} остановлено.");

                        break;
                    }
                }

            }

        }

        /*public void show()
        {
            foreach (Good good in goods)
            {
                Console.WriteLine(good.name);
            }

        }*/

        public override string ToString()
        {
            return $"{Name}.";
        }
    }
}
