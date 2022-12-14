using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class range
    {
        public static void prime()
        {
            Console.WriteLine("please enter range");
            int num = Int32.Parse(Console.ReadLine());
            int num1 = Int32.Parse(Console.ReadLine());
            // Boolean isprime = true;
            for (int n = num; n <= num1; n++)
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(n);
                }

            }

        }
        
    }

}
    

