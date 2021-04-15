using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    interface IPromote
    {
        public void Sell(int count_tickets);
        public void Calc_time(Planet a, double path); // коллизия имен при имплементации обоих интерфейсов
        //public void Upgrade(); - метод, который изменяет числовые поля объекта можно доработать
    }
}
