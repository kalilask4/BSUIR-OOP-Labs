using System;
using System.Collections.Generic;

namespace OOPlaba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Если в конструктор ничего не передавать, создается автосервис с 1 станцией ТО, вместимостью 1 авто
            //AutoService autoService1 = new AutoService();
            //Console.WriteLine(autoService1);

            //AutoService autoService2 = new AutoService("Start");
            //Console.WriteLine(autoService2);

            //Если в конструктор передать имя и количество станций, создается автосервис нужным количеством станцией ТО, вместимостью 1 авто
            //AutoService autoService3 = new AutoService("New", 3);
            //Console.WriteLine(autoService3);

            //Если в конструктор передать имя и количество станций, создается автосервис нужным количеством станцией ТО, вместимостью 1 авто
            AutoService autoService4 = new AutoService("Big service", 3, 5);
            Console.WriteLine(autoService4);

            //Создадим несколько станций для нового автосервисного центра и добавим эти станции к автосервису
            Station for_VIP1 = new Station("VIP", 1, "Kali Laska, 4");
            Console.WriteLine("Одна из станций:");
            Console.WriteLine(for_VIP1);
            Station for_VIP2 = new Station("Number one", 1, "p. Swerties, 23-5");
            Station for_VIP3 = new Station("The Best for the best", 3, "v. Crohyq, 3");
            Station for_VIP4 = new Station("XO", 8, "There, 1");
            Station[] for_VIP = new Station[4];
            for_VIP[0] = for_VIP1;
            for_VIP[1] = for_VIP2;
            for_VIP[2] = for_VIP3;
            for_VIP[3] = for_VIP4;

            AutoService autoService5 = new AutoService("\"Deal!\"", for_VIP);
            Console.WriteLine(autoService5);

            //Создадим авто с двигателями(композиция, один к одному), водителей. Добавим водителей к авто
            Driver driver1 = new Driver("Rewyll Layt");
            Driver driver2 = new Driver("Sneg Vik");
            Driver driver3 = new Driver("Kali Fo");
            Driver driver4 = new Driver("Sto Dolphit");
            Driver driver5 = new Driver("E. Task");

            Car car1 = new Car("1AS2344-55", "343113998i"); //авто создается с двигателем. Надпись "Check engine!" - рандом
            Car car2 = new Car("2DF4412-23", "453420031i");
            Car car3 = new Car("3GH2043-15", "145345300i");
            Car car4 = new Car("4FR2321-22", "110533334i");
            Car car5 = new Car("5WQ2224-45", "034343434i");
            Car[] all_cars = new Car[5];

            all_cars[0] = car1;                                                                         //в цикл
            all_cars[1] = car2;
            all_cars[2] = car3;
            all_cars[3] = car4;
            all_cars[4] = car5;

            car1.driver = driver1;
            car2.driver = driver2;
            car3.driver = driver3;
            car4.driver = driver4;
            car5.driver = driver5;

            driver1.car = car1;
            driver2.car = car2;
            driver3.car = car3;
            driver4.car = car4;
            driver5.car = car5;

            //Console.WriteLine($"Авто {car5.Number} водитель {car5.driver.Name}, двигатель {car5.engine.Vin}");

            //Запросим регистрацию 1 неисправного авто
            Console.WriteLine($"\n----- Регистрация одного неисправного авто -----");
            Driver driver6 = new Driver("Siri Kiton");
            Car car6 = new Car("6BB2334-00", "2485551i", null, driver6);
            car6.engine.Message = "Check engine!"; car6.engine.is_varning = true; //"сломаем" машину

            Console.WriteLine($"Регистрация на диагностику авто {car6.Number}, водитель {car6.driver.Name}");
            if (car6.engine.is_varning)
            {
                autoService5.stations[0].cars[0] = car6;

                Console.WriteLine($"Зарегистрировано. Вас ждут по адресу {autoService5.stations[0].Address}");
            }
            else
            {
                Console.WriteLine($"Aвто {car6.Number} не нуждается в диагностике");
            }
            //Проверим есть ли авто на регистрации в Автосервисе New, на 1 станции 
            Console.WriteLine($"Проверка регистрации. Aвто {car6.driver.Name} зарегистрировано  на станции {autoService5.stations[0].Name}? Номер зарегистрированного авто - {autoService5.stations[0].cars[0].Number}");
            Console.WriteLine($"---------------------------------------------");

            //------------------------------------------------------------------------------------


            //Проверим, на каких авто надпись Check engine
            Console.WriteLine($"-------Тест - какие машины неисправны-------");
            Console.WriteLine($"{car1.Number} Панель: {car1.engine.Message} Нужна диагностика? {car1.engine.is_varning}");
            Console.WriteLine($"{car2.Number} Панель: {car2.engine.Message} Нужна диагностика? {car2.engine.is_varning}");
            Console.WriteLine($"{car3.Number} Панель: {car3.engine.Message} Нужна диагностика? {car3.engine.is_varning}");
            Console.WriteLine($"{car4.Number} Панель: {car4.engine.Message} Нужна диагностика? {car4.engine.is_varning}");
            Console.WriteLine($"{car5.Number} Панель: {car5.engine.Message} Нужна диагностика? {car5.engine.is_varning}");
            Console.WriteLine($"--------------------------------------------");


            Console.WriteLine($"----- Регистрация всех неисправных авто -----");
            var faulty_cars = new List<Car>(Driver.CheckFaults(all_cars)); //CheckFaults() проверяет все авто и неисправные вносит в список faulty_cars
            //Зарегистрируем все наши авто из списка авто с неисправностями (faulty_cars). 
            //Ожидается, что все авто будут регистрироваться по очереди на каждую станцию.
            //если станция заполнена, авто будет зарегистрировано на след. станции
            Console.WriteLine($"\nСервис {autoService5.Name}. Cостояние всех станций, загруженность перед массовой регистрацией.");
            Console.WriteLine(autoService5);
            for (int i = 0; i < faulty_cars.Count; i++)
            {
                if (faulty_cars[i].engine.is_varning)
                {
                    //Console.WriteLine($"\nНовая регистрация******Станция {autoService5.Name}. Текущее состояние, загруженность.");
                    //Console.WriteLine(autoService5);
                    Console.WriteLine($"Регистрация на диагностику авто {faulty_cars[i].Number}, водитель {faulty_cars[i].driver.Name}");
                    Station reg_station = new Station();
                    reg_station = autoService5.registration(faulty_cars[i]);

                    Console.WriteLine($"Автомобиль {faulty_cars[i].Number} зарегистрирован на автосервисе {autoService5.Name} на станции {reg_station.Name} по адресу {reg_station.Address}");
                }
                else
                {
                    //Console.WriteLine("Данное авто не нуждается в диагностике");  //Здесь проверка избыточна. Оставила для расширения функциональности (перенести код в отдельную функцию и принимать список не только неисправных, а всех авто
                }
            }
            Console.WriteLine($"\nСервис {autoService5.Name}. Cостояние всех станций, загруженность после массовой регистрацией.");
            Console.WriteLine(autoService5);
        }
    }
}
