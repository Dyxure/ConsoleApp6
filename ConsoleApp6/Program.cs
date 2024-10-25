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
            Console.WriteLine("Введите число m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число Фибоначчи:{akkerman(m,n)}");
        }
        //Если вводится числа 0 или 1, то возвращается это же число - 0 или 1.
        //Иначе возвращается результат выражения Fibonachi(n - 1) + Fibonachi(n - 2);
        public static int fibonachi(int num)
        {
            if (num == 0 || num == 1) return num;

            return fibonachi(num - 1) + fibonachi(num - 2);
        }
        //если m равно 0, возвращаем n +1
        //Если m не равно 0, но n равно 0, вызываем функцию Ackerman с m-1 и 1
        //В остальных случаях вызываем Ackerman(n-1, Ackerman(n, m-1))
        public static int akkerman(int m, int n)
        {     
            if (m == 0) return n + 1;
            else if (n == 0) return akkerman(m - 1, 1);
            else return akkerman(m - 1, akkerman(m, n - 1));
        }

    }
}
