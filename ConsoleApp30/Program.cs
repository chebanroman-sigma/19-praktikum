using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{/// <summary>
/// 19 практикум
/// </summary>
    internal class Program
    {/// <summary>
     /// Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он
     /// увеличивал пробег на 10% от пробега предыдущего дня. Определить:
     ///а) в какой день он пробежит больше 20 км;

     /// </summary>
     /// <param name="args"></param>
     /// 

        static void Value()
        {
            int day = 1;
            double S = 10;
            double Roznica = 0.1;
            double sumS = 10;
            while (sumS<=20)
            {
                day++;
                sumS += sumS * Roznica;
            }Console.Write($"на {day}-й день лыжник пробежит больше 20км");
        }
        static void Main(string[] args)
        {
            Value();
            Console.ReadLine();
        }
    }
}
