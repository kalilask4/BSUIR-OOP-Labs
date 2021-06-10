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
                    case 3: insert(arrayList); break;
                    case 4: find_start(arrayList); break;
                    case 5: find_end(arrayList); break;
                    case 6: del(arrayList); break;
                    case 7: del_on_value(arrayList); break;
                     /*case 8: method8(arrayList); break;
                     case 9: method9(arrayList); break;*/
                    case 0: return;                       
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

        public static void insert(ArrayList arrayList)
        {
            Console.Write("индекс: ");
            string answer = Console.ReadLine();
            int n;
            if (!Int32.TryParse(answer, out n))
                return; 
            if (n < 0 || n > arrayList.Count)
            {
                Console.WriteLine("Неверный индекс");
                return;
            }
            Console.WriteLine("Добавляем Star(1) или NeutronStar(2)?");
            string answ = Console.ReadLine();
            int i;
            if (!Int32.TryParse(answ, out i) || i < 1 || i > 2)
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
                    arrayList.Insert(n, new Star(name, temperature_K, sun_mass));
                    break;
                case 2:
                    arrayList.Insert(n, new NeutronStar(name, temperature_K, sun_mass));
                    break;
            }
        }

        public static void find_start(ArrayList arrayList)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();
            Star star = new Star(name);
            int index = arrayList.IndexOf(star);
            Console.WriteLine(index > -1 ? $"\nИндекс = {index}; {arrayList[index]}" : "Элемент не найден");
        }

        public static void find_end(ArrayList arrayList)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();
            Star star = new Star(name);
            int index = arrayList.LastIndexOf(star);
            Console.WriteLine(index > -1 ? $"\nИндекс = {index}; {arrayList[index]}" : "Элемент не найден");
        }



        public static void del(ArrayList arrayList)
        {
            Console.Write("индекс: ");
            string answer = Console.ReadLine();
            int n;
            if (!Int32.TryParse(answer, out n))
                return;
            if (n < 0 || n > arrayList.Count)
            {
                Console.WriteLine("Неверный индекс");
                return;
            }
            arrayList.RemoveAt(n);
            Console.WriteLine("Элемент удален");
            show(arrayList);

        }

        public static void del_on_value(ArrayList arrayList)
        {

            Console.Write("name: ");
            string name = Console.ReadLine();
            Star star = new Star(name);
            arrayList.Remove(star);
            Console.WriteLine("Элемент удален (возможно)");
            show(arrayList);

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
