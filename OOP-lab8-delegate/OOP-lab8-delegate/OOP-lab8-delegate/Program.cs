using System;

namespace OOP_lab8_delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Add add = new Add();
            AddVIP addVIP = new AddVIP();

            Car carBat = new Car("Ford", "Lincoln Futura", 80, 50.0, 140, 38);
            Console.WriteLine(carBat.ToString());
            Car carRick = new Car("Chevrolet", "Caprice", 95, 80.0, 120, 9);
            Console.WriteLine(carRick.ToString());

            //carBat.delvoid += m1;
            //carBat.delvoid();

            //carRick.addDelvoid(m1);
            //carBat.addDelvoid(m1);
            //carBat.addDelvoid(m2);
            //carBat.addDelvoid(delegate () { Console.WriteLine("Stop!"); }); //анонимный делегат
            //carBat.addDelvoid(() => Console.WriteLine("Go!")); //лямбда

            Console.WriteLine("Вызов делегатов carRick");
            carRick.runDelvoid();
            Console.WriteLine();
            Console.WriteLine("Вызов делегатов carBat");
            carBat.runDelvoid();


            /*
            Console.WriteLine();
            Console.WriteLine("Сравнение делегатов");
            if(carBat.comparison(carRick))
            {
                Console.WriteLine("Делегаты равны");
            }
            else
            {
                Console.WriteLine("Делегаты не равны");
            }
            */


            Console.WriteLine();
            //делегат с параметром
            Console.WriteLine("Делегат с параметром");
            Console.WriteLine("До запрвки");
            Console.WriteLine($"Бак carRick {carRick.auto_brands} {carRick.Model} : {carRick.Fuel_quantity}/{carRick.Fuel_tank_capacity}");
            carRick.addDelparam(tank_up1);

            //Console.WriteLine("не делегат");
            //carRick.tank_up0(1);
            //Console.WriteLine($"Бак carRick {carRick.auto_brands} {carRick.Model} : {carRick.Fuel_quantity}/{carRick.Fuel_tank_capacity}");
            //Console.WriteLine("делегат");
            //carRick.On_tank_up += add.message();
            carRick.tank_up(1);
            Console.WriteLine($"Бак carRick {carRick.auto_brands} {carRick.Model} : {carRick.Fuel_quantity}/{carRick.Fuel_tank_capacity}");
            //Console.WriteLine(carRick.ToString());
            Console.WriteLine();
            Console.WriteLine("До запрвки");
            Console.WriteLine($"Бак carBat {carBat.auto_brands} {carBat.Model} : {carBat.Fuel_quantity}/{carBat.Fuel_tank_capacity}");
            carBat.addDelparam(tank_up2);
            carBat.tank_up(30);
            Console.WriteLine($"Бак carBat {carBat.auto_brands} {carBat.Model} : {carBat.Fuel_quantity}/{carBat.Fuel_tank_capacity}");
            //Console.WriteLine(carBat.ToString());

            Car carVinchester = new Car("Chevrolet", "Impala", 95, 95.0, 120, 9);
            Console.WriteLine(carVinchester.ToString());
            //Console.WriteLine("До запрвки");
            //Console.WriteLine($"Бак carVinchester {carVinchester.auto_brands} {carVinchester.Model} : {carVinchester.Fuel_quantity}/{carVinchester.Fuel_tank_capacity}");
            carVinchester.addDelparam(tank_up2);

            //carVinchester.addDelparam(delegate(double d) { return d + 3; });//анонимный делегат
            //carVinchester.addDelparam(d => d*10);//лямбда

            //события
            carVinchester.On_tank_up += add.message;
            carVinchester.tank_up(10);
            Console.WriteLine($"Бак carVinchester {carVinchester.auto_brands} {carVinchester.Model} : {carVinchester.Fuel_quantity}/{carVinchester.Fuel_tank_capacity}");

            Console.WriteLine();
            Car carRussHanneman = new Car("McLaren", "650S Spider", 100, 20, 120, 9);
            carRussHanneman.addDelparam(tank_up1);
            carRussHanneman.On_tank_up += add.message;
            carRussHanneman.On_tank_up += addVIP.message;
            carRussHanneman.tank_up(20);
            Console.ReadKey();

            //обратный вызов


        }

        static void m1()
        {
            Console.WriteLine("Ready Player1");
        }

        static void m2()
        {
            Console.WriteLine("Ready Player2");
        }

        static double tank_up1(double fuel_quantity)
        {

            return fuel_quantity *= 10;
        }

        static double tank_up2(double fuel_quantity)
        {
            // Console.WriteLine($"Попытка заправки на {fuel_quantity}");
            return fuel_quantity += 10;
        }

    }
}
