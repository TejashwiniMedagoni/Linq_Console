using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class SumOfDigit
    {
        public static void sum()
        {
            int sum = 0;
            Console.WriteLine("enter number");
            int num=Int32.Parse(Console.ReadLine());
            while(num > 0)
            {
                int digit=num%10;
                sum=sum+digit;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
