using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{/// <summary>
/// 19 практикум
/// </summary>
    internal class Program
    {/// <summary>
     /// Задача 1. Вывести первые пять членов арифметической прогрессии 
     /// (с использованием цикла), если a1=1, d=4 (например, 1  5  9  13  17).
     /// </summary>
     /// <param name="args"></param>
     /// 


        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static void Value()
        {
            int a1 = Input("a1= ");
            int d = Input("d1= ");
            int y,a;
            a = a1;
            for (a = 0; a <= 5; a++) 
            { 
                
                y = a1+a*d;
                Console.Write($"{y}  ");
            }Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Value();
            Console.ReadKey();
        }
    }
}
