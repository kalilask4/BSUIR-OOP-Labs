using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lab6_param_coll
{
    class Helper
    {
        public static void launch_menu(ArrayList arrayList)
        {
            while (true)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("*     Главное меню         *");
                Console.WriteLine("****************************");
                Console.WriteLine("1 – просмотр коллекции");
                Console.WriteLine("2 – добавление элемента");
                Console.WriteLine("3 – добавление элемента по указанному индексу");
                Console.WriteLine("4 – нахождение элемента с начала коллекции");
                Console.WriteLine("5 – нахождение элемента с конца коллекции");
                Console.WriteLine("6 – удаление элемента по индексу");
                Console.WriteLine("7 – удаление элемента по значению");
                Console.WriteLine("8 – реверс коллекции");
                Console.WriteLine("9 – сортировка");
                Console.WriteLine("10 – выполнение методов всех объектов, поддерживающих Interface");
                Console.WriteLine("0 – выход");
                int otvet = Convert.ToInt32(Console.ReadLine());
                switch (otvet)
                {
                   /* case 1: Show(arrayList); break;
                    case 2: Add(arrayList); break;
                    case 3: Insert(arrayList); break;
                    case 4: Find_start(arrayList); break;
                    case 5: Find_end(arrayList); break;
                    case 6: Del(arrayList); break;
                    case 7: Del_on_value(arrayList); break;
                    case 8: Revers(arrayList); break;
                    case 9: Sort(arrayList); break;
                    case 10: Glove(arrayList); break;*/
                    case 0: return;
                    default: return;
                }
            }
        }


        public static void Imitate_loading(string str)
        {
            Thread.Sleep(50);
            Console.Write("\n");
            Thread.Sleep(50);
            Console.Write(".");
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(50);
            Console.Write("..");
            Thread.Sleep(100);
            Console.Write("...");
            Thread.Sleep(100);
            Console.Write("....");
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(str);
            Thread.Sleep(50);
            Console.Write("...");
            Thread.Sleep(100);
            Console.Write("....");
            Thread.Sleep(50);
            Console.Write("...............");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(10);
            Console.Write(".");
            Thread.Sleep(10);
            Console.Write(".\n");
        }
    }

}
