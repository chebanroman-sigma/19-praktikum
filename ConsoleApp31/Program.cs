using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{/// <summary>
/// 19 практикум
/// </summary>
    internal class Program
    {/// <summary>
     /// Задача 5. Начав тренировки, лыжник в первый день пробежал 10 км. Каждый 
     /// следующий день он увеличивал пробег на 10% от пробега предыдущего дня.
     /// Определить:
     ///б) в какой день суммарный пробег за все дни превысит 100 км.
    /// </summary>
        static void Value()
        {
            int day = 1;
           
            double Roznica = 0.1;
            double sumS = 0;
            while (sumS < 100)
            {
                double S = 10;
                day++;
                S += sumS* Roznica;
                sumS += S;

            }
            Console.Write($"на {day}-й день лыжник суммарно пробежит больше 100км");
        }
        static void Main(string[] args)
        {
            Value();
            Console.ReadLine();
        }
    }
}
