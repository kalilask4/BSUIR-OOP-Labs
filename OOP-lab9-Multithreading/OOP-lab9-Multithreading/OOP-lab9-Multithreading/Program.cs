using System;

namespace OOP_lab9_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo
            //произвести товар (dt = random)
            //принять товар (0t)
            //купить товар (dt = 2sec)
            //списать со склада (0t)
            //проверка наличия товаров (0t)
            //проверка заполненности склада (0t)

            //обекты: склад, производитель(3), товар(*), покупатель(1 условный)

            //mess => отгружен
            //        куплен
            //        переучет

            Warehouse warehouse = new Warehouse(50);
            Console.WriteLine(warehouse);
        }
    }
}
