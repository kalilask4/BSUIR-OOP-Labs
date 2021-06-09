using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lab6
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
                    case 1: show(arrayList); break;
                    case 2: add(arrayList); break;
                    /*case 3: method3(arrayList); break;
                   case 4: method4(arrayList); break;
                    case 5: method5(arrayList); break;
                    case 6: method6(arrayList); break;
                    case 7: method7(arrayList); break;
                    case 8: method8(arrayList); break;
                    case 9: method9(arrayList); break;*/
                    default: return;
                }

                

            }

            
        }


        public static void show(ArrayList arrayList)
        {
            foreach (object obj in arrayList)
            {
                Console.WriteLine((obj as Star)?.ToString());
            }
            Console.ReadKey();
            
        }



        public static void add(ArrayList arrayList)
        {
            Console.WriteLine("Добавляем Star(1) или NeutronStar(2)?");
            string answer = Console.ReadLine();
            int n;
            if (!Int32.TryParse(answer, out n) || n < 1 || n > 2)
                return;
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("temperature_K: ");
            double temperature_K = double.Parse(Console.ReadLine()); 
            Console.Write("sun_mass: ");
            double sun_mass = double.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    arrayList.Add(new Star(name, temperature_K, sun_mass));
                    break;
                case 2:
                    arrayList.Add(new NeutronStar(name, temperature_K, sun_mass));
                    break;
            }
        }

       





        public static void imitate_loading(string str)
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
