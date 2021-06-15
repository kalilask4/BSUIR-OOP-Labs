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
        public static void launch_menu(Queue queue)
        {
            while (true)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("*     Главное меню         *");
                Console.WriteLine("****************************");
                Console.WriteLine("1 – просмотр коллекции");
                Console.WriteLine("2 – добавление элемента в конец");
                Console.WriteLine("3 – показать первый объект в очереди");
                Console.WriteLine("4 – показать(обработать) первый объект в очереди и удалить");
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
                    case 1: Show(queue); break;
                    case 2: Add(queue); break;
                    case 3: Show_First(queue); break;
                    case 4: Process_First(queue); break;
                    case 0: return;
                    default: return;
                }
            }
        }

       
        public static void Show(Queue queue)
        {
            foreach (object obj in queue)
            {
                Console.WriteLine((obj as Star)?.ToString());
            }
            Console.ReadKey();

        }



        public static void Add(Queue queue)
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
                    queue.Enqueue(new Star(name, temperature_K, sun_mass));
                    break;
                case 2:
                    queue.Enqueue(new NeutronStar(name, temperature_K, sun_mass));
                    break;
            }
        }

        public static void Show_First(Queue queue)
        {
            Console.Write("Первый в очереди - ");
            Console.WriteLine((queue.Peek() as Star)?.ToString());
            Console.ReadKey();

        }

        public static void Process_First(Queue queue)
        {
            string answer;
            int n=1;

            while (n == 1)
            {

                Console.Write("Первый в очереди - ");
                Console.WriteLine((queue.Dequeue() as Star)?.ToString());
                Console.WriteLine("Обработан, удален");
                Console.WriteLine("Продолжить (1) или закончить(0)?");

                answer = Console.ReadLine();
                if (!int.TryParse(answer, out n))
                    return;

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
