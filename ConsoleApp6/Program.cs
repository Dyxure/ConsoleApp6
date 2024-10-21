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
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(reverse(num));
        }
        public static int reverse(int num)
        {
            if (num == 0)
                return 0;
            else
                return (num % 10) + 10 * reverse(num / 10);
        }
    }
}
