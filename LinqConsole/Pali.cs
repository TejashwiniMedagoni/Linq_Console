using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Pali
    {
        public static void polli()
        {
            Console.WriteLine("enter any number");
            int num = Int32.Parse(Console.ReadLine());
            int temp = num;
            int rev = 0;
            while(num > 0)

            {
                int digit=num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            if(rev==temp)
            {
                Console.WriteLine("pallindrome");
            }
            else
            {
                Console.WriteLine("not pallindrome");
            }
        }
    }
}
