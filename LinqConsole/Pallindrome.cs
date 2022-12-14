using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Pallindrome
    {
        public static void pallindrome1()
        {
            Console.WriteLine("enter any number");
            int num=int.Parse(Console.ReadLine());
            int rev = 0;
            int temp = num;
            while (num!=0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }
            if(temp==rev)
            {
                Console.WriteLine("pallindrome");
            }
            else
            {
                Console.WriteLine("not a pallindrome");
            }
        }
    }
}
