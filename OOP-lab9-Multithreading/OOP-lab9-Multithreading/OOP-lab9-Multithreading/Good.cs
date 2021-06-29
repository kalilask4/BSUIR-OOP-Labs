using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab9_Multithreading
{
    class Good
    {
        public string name;
        public string model="no model";
        public Maker maker = new Maker("no Maker", 1, new List<Good>(), new List <Good>());
        public double base_produce_time = 1;

        public Good(string name)
        {
            this.name = name;
        }

        public Good(string name, int base_produce_time) : this(name)
        {
            this.base_produce_time = base_produce_time;
        }

        public Good(Good sample_good, Maker maker, string model) : this(sample_good.name)
        {
            this.model = model;
            this.maker = maker;
        }

        public override string ToString()
        {
            return $"{name} {model} {maker.Name} {base_produce_time}";
        }


        /*public Good(string name, string model, Maker maker, int produce_time)
        {
            this.name = name;
            this.model = model;
            this.maker = maker;
            this.base_produce_time = produce_time;
        }*/



    }
}
