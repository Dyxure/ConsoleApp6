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
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число:{ reverse(num)}");
            Console.WriteLine("Введите число:");
            int fibnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число Фибоначчи:{fibonachi(fibnum)}");
        }
        public static int reverse(int num, int revnum = 0)
        {
            if (num == 0)
            {
                return revnum;
            }
            else
            {
                revnum = (revnum * 10) + (num % 10);
                return reverse(num / 10, revnum);
            }
        }

        public static int fibonachi(int num)
        {
            if (num == 0 || num == 1) return num;

            return fibonachi(num - 1) + fibonachi(num - 2);
        }
    }
}
