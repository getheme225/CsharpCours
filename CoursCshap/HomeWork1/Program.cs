using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] number = new uint[3];

            Console.WriteLine("Вводите 3 числа (ps: между каждого числа вставить пробел) :  ");
            number = StringNumberArrayToInTArray(Console.ReadLine().Split());

            Console.WriteLine("Наименьшее : " + number.Min()); // наименьшее число

            foreach (int a in number)
            {
                PrintfibonacciList(a).ForEach(item => Console.Write(item + " "));
                Console.WriteLine();
            }
            Console.Read();
        }

        static uint[] StringNumberArrayToInTArray(string[] user_input)
        {
            uint[] IntArray = new uint[user_input.Length];
            try
            {
                for (int i = 0; i < user_input.Length; i++)
                {
                    IntArray[i] = uint.Parse(user_input[i]);
                }
            }
            catch
            {
                Console.WriteLine("ввели не число");
            }
            return IntArray;
        }

        static List<int> PrintfibonacciList(int input)
        {
            List<int> result = new List<int>();
            int a = 0;
            int b = 1;
            result.Add(a);
            for (int i = 0; i < input && a < input; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                result.Add(a);
            }
            return result;
        }
    }
}
