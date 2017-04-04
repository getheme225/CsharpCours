using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Настройка Автомобил..........");
            Console.WriteLine("Введите название автомобиля: ");
            string autoName = Console.ReadLine();
            Console.WriteLine("Введите количества колес автомобиля: ");
            uint countOfWheels;
            if (!TryParseStringToUint(Console.ReadLine(), out countOfWheels)) return;
            Console.WriteLine("Введите количества дверей автомобиля: ");
            uint countOfDoor;
            if (!TryParseStringToUint(Console.ReadLine(), out countOfDoor)) return;

            Console.Clear();
            Console.WriteLine("Run tester ............");
            Console.WriteLine("Вводите номер колесо:");
            uint numberOfWhell;
            if (!TryParseStringToUint(Console.ReadLine(), out numberOfWhell)) return;
            Console.WriteLine("Вводите номер двери:");
            uint numberOfdoor;
            if (!TryParseStringToUint(Console.ReadLine(), out numberOfdoor)) return;

            Car ourCar = new Car(countOfWheels, countOfDoor, numberOfWhell, numberOfdoor, autoName);
            RunTester(ourCar, numberOfWhell, numberOfdoor);
        }

        private static void MoveButton(Car car)
        {
            foreach (var detail in car.DetailsArray)
            {
                Console.WriteLine((detail as IRotatable)?.Move(car.Model));
            }
        }

        private static void OpenButton(Car car, uint doorNumber)
        {
            IDoor openableDetail =
                car.DetailsArray.Where(detail => detail is IDoor)
                    .Cast<IDoor>()
                    .SingleOrDefault(idoorItem => doorNumber == 0 ? idoorItem is Body : (idoorItem is Door));
            Console.WriteLine(openableDetail?.Open(car.Model));
        }

        private static bool TryParseStringToUint(string input, out uint output)
        {
            if (uint.TryParse(input, out output)) return true;
            Console.WriteLine("Неверные настройки программы");
            return false;
        }

        private static void RunTester(Car car, uint numberOfWheel, uint numberOfDoor)
        {
            do
            {
                Console.WriteLine("-----------Меню------------");
                Console.WriteLine($"1- Move Колесо №{numberOfWheel} ");
                Console.WriteLine($"2-Open Door № {numberOfDoor}");
                Console.WriteLine("3- entrer exit to close");
                Console.WriteLine("-----------------------------");
                switch (Console.ReadLine())
                {
                    case "1":

                        MoveButton(car);
                        break;
                    case "2":
                        OpenButton(car, numberOfDoor);
                        Console.WriteLine("press Enter to close the door");

                        if (Console.ReadKey(true).Key == ConsoleKey.Enter) OpenButton(car, numberOfDoor);
                        else break;
                        break;
                    default:
                        return;
                }
            }
            while (Console.ReadLine() == "exit") ;
            
        }
    }
}
