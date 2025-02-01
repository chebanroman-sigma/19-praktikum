using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static void Value()
        {
            int a1 = Input("a1= ");
            int d = Input("d1= ");
            int y, a;
            int sum = 0;
            a = a1;
            for (a = 0; a <= 5; a++)
            {

                y = a1 + a * d;
                sum = sum + y;
                Console.Write($" {y}");
            }
            Console.WriteLine($", sum={sum}");
        }
        static void Main(string[] args)
        {
            Value();
            Console.ReadKey();

        }
    }
}
