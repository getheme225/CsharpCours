﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            WorkWithOneString homeWorkClass = new WorkWithOneString(Console.ReadLine());
            homeWorkClass.ToConsole();
           
        }
    }
}
