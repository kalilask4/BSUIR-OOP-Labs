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
        public string model;
        public Maker maker;
        public int produce_time;

        public Good(string name, string model, Maker maker, int produce_time)
        {
            this.name = name;
            this.model = model;
            this.maker = maker;
            this.produce_time = produce_time;
        }
    }
}
