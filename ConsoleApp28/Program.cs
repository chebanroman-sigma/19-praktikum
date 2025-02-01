using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{/// <summary>
/// 19 практикум
/// </summary>
    internal class Program
    {/// <summary>
     /// Задача 3. Родители ко дню рождения своего сына Андрея решили купить и 
     /// обновить ему мобильный телефон. Для этого они в первый месяц отложили 
     /// 100 руб., а в каждый последующий на 50 рублей больше. Какая сумма будет 
     /// через десять месяцев?
     /// </summary>

        static void Value()
        {
            int vklad1 = 100;//первоначальный вклад
            int roznica = 50;
            int sum=0;
            for (int i = 0; i < 10; i++)
            {
                int vklad2 = vklad1 + roznica * i;//вклад за каждый месяц

                sum += vklad2;

            }Console.WriteLine($"{sum} руб.");
        }
        static void Main(string[] args)
        {
            Value();
            Console.ReadKey();

        }
    }
}
