using System;

namespace OOP_lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Bird[] birds = new Bird[5] { new Bird("Ласточка", 6), new Bird("Дрозд", 3), new Duck("Серая утка", 5, 5.6), new Duck("Селезень", 8, 6.7), new Bird("Кукушка", 8) };
             ArrayList arrayList = new ArrayList();
             arrayList.Add(new Bird("Пеночка", 9));
             arrayList.AddRange(birds);*/


            /*Helper helper = new Helper();*/
            Helper.imitate_loading("Obj1 - Sun..............");
            Star star1 = new Star("Sun", 5778, 1);
            Console.WriteLine(star1.ToString());
            star1.print_description();

            Helper.imitate_loading("Obj2 - Star.............");
            Star star2 = new Star("Naos", 42000, 40, 19643814, 1076, "Zeta Puppis is a blue star in the constellation of Puppis.");
            Console.WriteLine(star2.ToString());
            star2.print_description("Suhail Khadar - the brightest roar (Arabic)");

            Helper.imitate_loading("Obj2 - Star.............");
            NeutronStar neutronStar1 = new NeutronStar("Alma Star", 17, 111, 8, 2663568, 168000, "");
            Console.WriteLine(neutronStar1);
            neutronStar1.print_description("SN 1987A was a type II supernova in the Large Magellanic Cloud, a dwarf satellite galaxy of the Milky Way.");

            Console.WriteLine(star1.CompareTo(star2));
            star2.CompareTo(neutronStar1);


            /*while (true)
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
                    case 1: method1(arrayList); break;
                    case 2: method2(arrayList); break;
                    case 3: method3(arrayList); break;
                    case 4: method4(arrayList); break;
                    case 5: method5(arrayList); break;
                    case 6: method6(arrayList); break;
                    case 7: method7(arrayList); break;
                    case 8: method8(arrayList); break;
                    case 9: method9(arrayList); break;
                    default: return;
                }
            }*/
        }


    
}
}
