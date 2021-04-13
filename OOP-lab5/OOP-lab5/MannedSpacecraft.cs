﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab5
{
    //реализует 2 интерфейса - IMoving, IPromote
    class MannedSpacecraft : Spacecraft, IMoving, IPromote
    {
        public MannedSpacecraft()
        {
        }

        public MannedSpacecraft(string name, string use, double speed) : base(name, use, speed)
        {
        }

        public new void Move(Planet a, Planet b) //метод из Imoving, из родительского класса, переопределен
        {
            Console.WriteLine("Traveling from " + a.Name + " to " + b.Name);
        }



        public void Calc_time(Planet a, double path)  //склеивание - метод из двух классов реализован 1 раз
         {
             Console.WriteLine("Travel time will take " + Math.Round((a.Earth_distance + path / this.Speed), 2) + " years");
         }

        void IPromote.Calc_time(Planet a, double path) //кастинг
        {
            throw new NotImplementedException();
        }

        void IMoving.Calc_time(Planet a, double path) //кастинг
        {
            throw new NotImplementedException();
        }


        void IPromote.Sell()
        {
            throw new NotImplementedException();
        }





    }
}