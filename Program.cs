using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            double procent;
            Console.WriteLine("Введите сумму вклада:");
            double sum_before = Convert.ToDouble(Console.ReadLine());
            if (sum_before < 200 & sum_before > 100)
            {
                procent = 0.07;

            }
            else if (sum_before > 200)
            {
                procent = 0.1;
            }
            else
            {
                procent = 0.05;
            }
            Console.WriteLine($"Общая сумма с начисленными процентами: {sum_before + sum_before * procent}");
            Console.ReadKey();
        }

    }
}
