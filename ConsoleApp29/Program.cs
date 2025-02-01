using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{/// <summary>
/// 19 praktukym
/// </summary>
    internal class Program
    {/// <summary>
     /// Задача 4. Составьте программу вычисления суммы 150 первых членов арифметической 
     /// прогрессии, если a1= –200; d = 0,2.
     /// </summary>
     /// <param name="args"></param>
        

        static void Value()
        {
            double a1 = -200;
            double d =0.2;
            double y, a;
            double sum = 0;
            for (a = 0; a < 150; a++)
            {

                y = a1 + a * d;
                sum += y;
                
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Value();
            Console.ReadKey();

        }
    }
}
