using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class srihan
    {
        public static void armstrong()
        {
            Console.WriteLine("please enter the starting range");
            int x=Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter the ending range");
            int y = Int32.Parse(Console.ReadLine());
            int count = 0;
            int temp = x;
            int check = x;
            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                while (x != 0)
                {
                    count++;
                    x /= 10;
                }
                while (temp != 0)
                {
                    int digit = x % 10;
                    int power = 1;
                    for (int j = 1; j < count; j++)
                    {
                        power *= digit;
                    }
                    sum += power;
                    temp /= 10;
                }

                    if (sum == check)
                    {
                        Console.WriteLine(check);

                    }

                }
            
            }

        }
    }

