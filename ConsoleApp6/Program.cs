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
            int revnum = 0;

            while (num != 0)
            {
                revnum = revnum * 10 + num % 10;
                num = num / 10;
            }

            return revnum;
        }
    }
}
