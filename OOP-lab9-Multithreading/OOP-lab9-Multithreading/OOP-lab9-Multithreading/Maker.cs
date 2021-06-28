using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab9_Multithreading
{
    class Maker
    {
        private string name; //hp, gigabite, amd
        List<Good> goods; //список товаров, которые данный производитель может производить


        public enum SCALE { Unit = 100, SmallScale = 40, MediumScale = 20, BigScale = 10, Mass = 1, };//чем выше масштаб производства, тем быстрее производиться тот или иной товар
                                                                              //(здесь коэффициент - для расчета времени производства от базового))
                                //свыше 40 — единичное производство;
                                //от 20 до 40 вкл. — мелкосерийное производство;
                                //от 10 до 20 вкл. — среднесерийное производство;
                                //от 1 до 10 вкл. — крупносерийное производство;
                                //равный 1 — массовое производство.


        public string Name { get => name; set => name = value; }
        public SCALE sCALE { get; set; }

        public Maker(string name, SCALE sCALE)
        {
            this.name = name;
            this.sCALE = sCALE;
        }

       /* public string show_goods()
        {
        foreach good in this.goods{
                return (good.name).Tostring();
            }
            
        }*/

        public Good makeGood(string name)
        {
            Good good = new Good(name);
            return good;
        }

        public override string ToString()
        {
            return $"{Name}, scale - {sCALE}.";
        }
    }
}
