using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 7. В заданном массиве найти среднее арифметическое положительных 
    чисел, среднее арифметическое отрицательных чисел и число нулей.*/

namespace Lab_4_1_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[25];
            Random r = new Random();

            double sum_plus = 0;            double sum_minus = 0;
            int count_plus = 0;            int count_minus = 0;
            int count_zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-25, 25);
                if (arr[i] > 0)
                {
                    sum_plus += arr[i];
                    count_plus++;
                }
                if (arr[i] < 0)
                {
                    sum_minus += arr[i];
                    count_minus++;
                }
                if (arr[i] == 0)
                    count_zero++;                
            }
            double sred_plus = sum_plus / count_plus;
            double sred_minus = sum_minus / count_minus;

            foreach (var item in arr)            
                Console.Write(item + " ");
            Console.WriteLine();
            Console.WriteLine($"Среднее арифметическое положительных чисел: {sred_plus}");
            Console.WriteLine($"Среднее арифметическое отрицательных чисел: {sred_minus}");
            Console.WriteLine($"Число нулей: {count_zero}");

            // Linq
            Console.WriteLine("Плюс  " + arr.Where(i => i > 0).Average());
            Console.WriteLine("Минус " + arr.Where(i => i < 0).Average());
            Console.WriteLine("Нулей " + arr.Where(i => i == 0).Count());

            Console.ReadKey();
        }
    }
}
