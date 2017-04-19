using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork8_DLL;
namespace HomeWork7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Инициализировать данные перевоначальльным состоянием.

            Bank mybank = new Bank();
            Employee emp1 = new Employee("emp1", 123456, Function.Administrator);
            Employee emp2 = new Employee("emp2", 1256, Function.Operator);
            Employee emp3 = new Employee("emp3", 123458, Function.Cashier);

            mybank.AddNewEmployees(emp1);
            mybank.AddNewEmployees(emp2);
            mybank.AddNewEmployees(emp3);

            #endregion

            #region Провести моделирование ряда случайных процессов с выводом результата на консоль.

            Random rnd = new Random();
            string message;
            Client client1 = new Client("client1", 1, (RequieredOperation) rnd.Next(0, 2));
            Client client2 = new Client("client1", 1, (RequieredOperation) rnd.Next(0, 2));
            Client client3 = new Client("client1", 1, (RequieredOperation) rnd.Next(0, 2));

            mybank.CanWorkWithClient(client1,rnd.Next(0,2000), out message);
            Console.WriteLine(message);
            Console.WriteLine();

            mybank.CanWorkWithClient(client2, rnd.Next(0, 2000), out message);
            Console.WriteLine(message);
            Console.WriteLine();

            mybank.CanWorkWithClient(client3, rnd.Next(0, 2000), out message);
            Console.WriteLine(message);
            Console.WriteLine();
            Console.Read();
            #endregion
        }
    }
}
