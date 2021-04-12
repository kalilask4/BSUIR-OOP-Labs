using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    interface IPromote
    {
        public void Sell();
        public void Calc_time(Planet a, double path); //здесь будет конфликт имен при имплементации обоих интерфейсов
    }
}
