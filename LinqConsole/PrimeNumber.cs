using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class PrimeNumber
    {
        public static void prime()
        {
            Console.WriteLine("enter any number");
            int num = Int32.Parse(Console.ReadLine());
            
            Boolean isprime = true;
                for (int i = 2; i < num/2; i++)
                {
                    if (i%num == 0)
                    {
                        isprime = false;
                        break;
                    }

                }
                if (isprime)
                {
                    Console.WriteLine("prime");
                }

                else
                {
                    Console.WriteLine("not prime");
                }
               
            }
        }
    }

