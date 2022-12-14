using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class strongNum
    {
        public static void strong()
        {
            Console.WriteLine("Enter any number");
            int n=Int32.Parse(Console.ReadLine());
            int sum = 0;
            int temp = n;
            while(n!=0)
            {
                int digit = n % 10;
                int fact = 1;
                for(int i = 0; i < digit; i++)
                {
                    fact *= digit;
                }
                sum += fact;
                n /= 10;
            }
        }
    }
}
