using OOPlaba4;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab4
{
    class Asteroid : AstronomicalObject
    {
        public Asteroid(string name) : base(name)
        {
            Type_object = "Asteroid";
        }

        public override double ad()
        {
            throw new NotImplementedException();
        }
    }
}
