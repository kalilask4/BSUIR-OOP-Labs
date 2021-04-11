using System;

namespace OOPlaba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine(car1);
            Car car2 = new Car("Dodge");
            Console.WriteLine(car2);
            Car car3 = new Car("Alfa Romeo", "Alfa Romeo", 92.5, 80.0, 105, 7, 2.5, 2.5, 2.3, 1.4); //
            Console.WriteLine(car3);
            // в массив добавлено значение, не проходящее по условию, exeption
            //Car car4 = new Car("Jeep", "", 92.5, 80.0, 130, 7, 3, 3, 2.9, 9); //
            //Console.WriteLine(car4);
            Car carRick = new Car("Chevrolet", "Caprice", 95, 80.0, 120, 9, 2.9, 3, 2.9, 3.9);
            Console.WriteLine(carRick);
            //массив превышен, но все работает благодаря params
            Car carElon = new Car("BMW", "3", 95, 85.0, 140, 9, 3, 3, 2.9, 2.9); //
            Console.WriteLine(carElon);
            //массив заполнен не полностью, но все работает благодаря params
            Car carBat = new Car("Ford", "Lincoln Futura", 80, 50.0, 140, 2, 2, 2.9); //
            Console.WriteLine(carBat);

            Car carBat_copy = carBat;
            Console.WriteLine("carBat_copy is carBat: ");
            //Console.WriteLine(carBat_copy == carBat);
            Console.WriteLine("Speed carBat before changing ");
            Console.WriteLine(carBat.Current_speed);
            Console.WriteLine("Speed carBat after changing copy carBat: ");
            carBat_copy.Current_speed = 150;
            Console.WriteLine(carBat.Current_speed);
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Calculation remainder mileage");
            Console.WriteLine("Remainder mileage for {0} {1} are {2} km.",
                carBat.auto_brands, carBat.Model, carBat.calc_remainder_mileage());
            Console.WriteLine("Remainder mileage for {0} {1} are {2} km.",
                carBat.auto_brands, carBat.Model, carBat.calc_remainder_mileage());
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Сheck wheel breakdown");
            car3.check_wheel_breakdown();
            carElon.check_wheel_breakdown();
            Console.WriteLine("__________________________________________");
            //Console.WriteLine(carElon.is_car_faster(carRick));
            Console.WriteLine("Determining more faster car. Is {1} {2} faster then {2} {3}: {4}.",
                carRick.auto_brands, carRick.Model, carElon.auto_brands, carElon.Model, carRick.is_car_faster(carElon));
            Console.WriteLine("__________________________________________");
            Car fastest_car = Car.search_the_fastest_car(carBat, carElon, carRick);
            Console.WriteLine("Determining the fastest car. Among {0} {1}, {2} {3}, {4} {5} the fastest car is {6} {7}.",
                carBat.auto_brands, carBat.Model, carElon.auto_brands, carRick.Model, carRick.auto_brands, carRick.Model,
                fastest_car.auto_brands, Car.search_the_fastest_car(carBat, carElon, carRick).Model);

        }
    }
}
