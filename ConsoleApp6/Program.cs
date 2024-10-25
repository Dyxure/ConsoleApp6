using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int fibnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число Фибоначчи:{fibonachi(fibnum)}");
        }
        //Если вводится числа 0 или 1, то возвращается это же число - 0 или 1.
        //Иначе возвращается результат выражения Fibonachi(n - 1) + Fibonachi(n - 2);
        public static int fibonachi(int num)
        {
            if (num == 0 || num == 1) return num;

            return fibonachi(num - 1) + fibonachi(num - 2);
        }
    }
}
