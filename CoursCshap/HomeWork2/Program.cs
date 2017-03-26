using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число : ");

            uint number;      // Размер массива не может быть отрицательным !!!!!!!
            if (!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ввели не правильно");
                Console.Read();
                return;
            }

            Console.WriteLine("генерируем Массив ......");
            Random rnd = new Random();
            int[] array = GenerateRandomArrayOfInputedNumber(number);
            PrintArray(array);

            Console.WriteLine("Отсортируем Массив .........");
            BubbleSort(array);
            PrintArray(array);
            Console.Read();
        }

        static void PrintArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        static void BubbleSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static int[] GenerateRandomArrayOfInputedNumber(uint input)
        {
            Random rnd = new Random();
            int[] array = new int[input];
            for (int i = 0; i < input; i++)
            {
                array[i] = rnd.Next(-10, 30);
            }
            return array;
        }
    }
}
