using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    interface IMoving
    {
        public void Move(Planet a, Planet b);
        public void Calc_time(Planet a, double path);//здесь будет конфликт имен при имплементации обоих интерфейсов
    }
}
