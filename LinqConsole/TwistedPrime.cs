using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class TwistedPrime
    {
        public static void main1()
        {
            Console.WriteLine("enter any number");
            int num=Int32.Parse(Console.ReadLine());
            int temp = num;
            int rev = Reverseno(num);

           
            if (Isprime(temp) && Isprime(rev))
            {
                Console.WriteLine("twisted prime");
            }
            else
                Console.WriteLine("not twisted prime");

        }
        public static bool Isprime(int num)
        {
            bool isprime=true;
            for(int i=2; i<num/2; i++)
            {
                if(num%i==0)
                {
                    isprime=false;
                    break;
                }
            }
            return isprime;

        }
        public static int Reverseno(int num)
        {
            int rev = 0;
            while(num>0)
            {
                rev = rev * 10 + num % 10;
                num/= 10;
            }
            return rev;
        }
        
    }
}
