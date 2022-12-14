using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class StrRev
    {
        public static void stringrev()
        {
            pro3();
            occurence();
            B2d();
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            string rev = null;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];

            }
            Console.WriteLine(rev);

        }
        /*  101
         *  1*2^0=1
         *  0*2^1=0
         *  1*2^2=4
         *  4+0+1=5
         *  
         */
        public static void B2d()
        {
            Console.WriteLine("Enter binary number");
            int num = int.Parse(Console.ReadLine());


            int res = 0;
            int i = 1, r;
            while (num > 0)
            {
                int digit = num % 10;
                r = digit * i;
                res = r + digit;
                num /= 10;
                i = i * 2;

            }
            Console.WriteLine(res);

        }
        public static void occurence()
        {
            Console.WriteLine("please provide input string");
            string s=Console.ReadLine();
            while(s.Length > 0)
            {
                int count = 0;
                Console.Write(s[0] + " = ");
                for(int i=0;i<s.Length;i++)
                {
                    if (s[0]==s[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(),String.Empty);
            }
        }
        public static void pro3()
        {
            Console.WriteLine("enter the binary value");
            int n=int.Parse(Console.ReadLine());
            int base1 = 1, result = 0;
            while(n>0)
            {
              int digit= n % 10;
                n = n / 10;
                result+= digit * base1;
                base1 = base1 * 2;
            }
            Console.WriteLine(result);
        }
    }
}
