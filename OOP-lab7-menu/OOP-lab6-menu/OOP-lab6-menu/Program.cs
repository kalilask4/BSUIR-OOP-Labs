using System;
using System.IO;

namespace OOP_lab7_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"E:\");         // текущий каталог по умолчанию
            try
            {
                while (true)
                {
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("*             Главное меню                         *");
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("1 – установить текущий диск/каталог");
                    Console.WriteLine("2 – вывод списка всех каталогов в текущем");
                    Console.WriteLine("3 – вывод списка всех файлов в текущем каталоге");
                    Console.WriteLine("4 – вывод на экран содержимого указанного файла ");
                    Console.WriteLine("5 – создание каталога в текущем");
                    Console.WriteLine("6 – удаление каталога по номеру, если он пустой");
                    Console.WriteLine("7 – удаление файлов с указанными номерами");
                    Console.WriteLine("8 – вывод списка всех файлов с указанной датой создания");
                    Console.WriteLine("9 – вывод списка всех текстовых файлов, в которых текст");
                    Console.WriteLine("0 – выход");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            f1(ref dir);
                            break;
                        case 2:
                            f2(dir);
                            break;
                        case 3:
                            f3(dir);
                            break;
                        case 4:
                            f4(dir);
                            break;
                        case 5:
                            f5(dir);
                            break;
                        case 6:
                            f6(dir);
                            break;
                        case 7:
                            f7(dir);
                            break;
                        case 8:
                            f8(dir);
                            break;
                        case 9:
                            f9(dir);
                            break;
                        case 0: return;
                        default:
                            return;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Неверное имя файла");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Неверное имя каталога");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
        }

        static void f1(ref DirectoryInfo d)
        {// установить текущий каталог
            Console.WriteLine($"Текущий каталог: {d}\nВведите новый каталог");
            string str = Console.ReadLine();
            if (str.Length == 0)
                return;
            if (Directory.Exists(d+str))
            {
                d = new DirectoryInfo(d+str);
                Console.WriteLine($"Текущий каталог: {d.FullName}");
            }
            else{
                Console.WriteLine($"Текущий каталог {str} не существует.");
            }
        }

        static void f2(DirectoryInfo d)
        {// вывод списка всех каталогов в текущем (пронумерованный)
            DirectoryInfo[] directories = d.GetDirectories();
            Console.WriteLine("Список подкаталогов");
            for (int i = 0; i < directories.Length; i++)
                Console.WriteLine($"{i} {directories[i]}");
        }

        static void f3(DirectoryInfo d)
        {// вывод списка всех файлов в текущем каталоге (пронумерованнный)
            FileInfo[] files = d.GetFiles();
            Console.WriteLine("Список файлов");
            for (int i = 0; i < files.Length; i++)
                Console.WriteLine($"{i} {files[i]}");

        }

        static void f4(DirectoryInfo d)
        {// вывод на экран содержимого указанного файла (по номеру)
            f3(d);
            Console.WriteLine("Введите номер файла:");
            int index = Convert.ToInt32(Console.ReadLine());
            FileInfo[] files = d.GetFiles();
            if (files[index].Extension != ".txt")
            {
                Console.WriteLine("Это не текстовый файл!");
                return;
            }
            StreamReader sr = new StreamReader(files[index].FullName);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
        }

        static void f5(DirectoryInfo d)
        {// создание каталога в текущем
            Console.WriteLine("Введите имя каталога ");
            string str = Console.ReadLine();
            if (Directory.Exists(str))
            {
                Console.WriteLine($"Каталог {str} уже существует");
                return;
            }
            d.CreateSubdirectory(str);
            Console.WriteLine($"Каталог {str} создан");
        }

        static void f6(DirectoryInfo d)
        {// удаление каталога по номеру, если он пустой
            f2(d);
            DirectoryInfo[] directories = d.GetDirectories();
            Console.WriteLine("Ведите номер каталога для удаления");
            int index = Convert.ToInt32(Console.ReadLine());
            if(index < 0 || index >= directories.Length)
            {
                Console.WriteLine("Неверный номер каталога");
                return;
            }
            if(directories[index].GetDirectories().Length == 0 && directories[index].GetFiles().Length == 0)
            {
                directories[index].Delete();
                Console.WriteLine($"Каталог удален");
            }
            else
            {
                Console.WriteLine($"Каталог не пуст") ;
            }
 
        }

        static void f7(DirectoryInfo d)
        {// удаление файлов с указанными номерами
            f3(d);
            Console.WriteLine("Введите номера первого и последнего файлов для удаления:");
            int index1 = Convert.ToInt32(Console.ReadLine());
            int index2 = Convert.ToInt32(Console.ReadLine());

            FileInfo[] files = d.GetFiles();
            if (index1 > index2 || index2 >= files.Length)
            {
                Console.WriteLine("неверные номера файлов");
                return;
            }
            for (int i = index1; i <= index2; i++)
                files[i].Delete();
            Console.WriteLine(index2 - index1 + 1 + " файлов удалено");
            f3(d);
        }

        static void f8(DirectoryInfo d)
        {// вывод списка всех файлов с указанной датой создания (ищет в текущем каталоге и подкаталогах)
            Console.WriteLine("Введите дату создания файла в формате ДД.ММ.ГГГГ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            FileInfo[] files = d.GetFiles("*", SearchOption.AllDirectories);
            for (int i=0; i< files.Length; i++)
            {
                if(files[i].CreationTime.Date.Equals(date.Date))
                    Console.WriteLine($"{i} {files[i].Name} {files[i].CreationTime}");
            }
        }

        static void f9(DirectoryInfo d)
        {// вывод списка всех текстовых файлов, в которых содержится указанный текст (ищет в текущем каталоге и подкаталогах)
            Console.WriteLine("Введите текст для поиска в файлах");
            string str = Console.ReadLine();
            FileInfo[] files = d.GetFiles("*", SearchOption.AllDirectories);
            int i = 0;
            foreach (FileInfo x in files)
            {
                if (x.Extension != ".txt") continue;
                StreamReader sr = new StreamReader(x.FullName);
                string buf = sr.ReadToEnd();
                if (buf.Contains(str))
                    Console.WriteLine(++i + ")" + x.DirectoryName + "\\" + x.Name);
            }
        }
    }
}
