using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Test
    {
        
        public static void testing()
        {
            Console.WriteLine("Enter any number");
            int n=Int32.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int temp = n;
            int check = n;
            while(n!=0)
            {
                count++;
                n /= 10;
            }
            while(temp!=0)
            {
                int digit = temp% 10;
                int power = 1;
                for(int i=1;i<=count;i++)
                {
                    power *= digit;
                }
                sum += power;
                temp /= 10;
            }
            if(sum==check)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }
        }
        

    }
}






