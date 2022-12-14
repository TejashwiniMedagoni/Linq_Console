using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Class5
    {
        public static void fact()
        {
            Class5.binary2deci();
            Class5.sum();
            Console.WriteLine("Enter number");
            int n=Int32.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
        public static void sum()
        {
            Console.WriteLine("number");
            int n=Int32.Parse(Console.ReadLine());
            int sum = 0;
            while(n!=0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        public static void binary2deci()
        {
            Console.WriteLine("enter number");
            int n=Int32.Parse(Console.ReadLine());
            int r;
            string res = "";
            while(n!=0)
            {
                r = n % 2;
                res = r + res;  
                n /= 2;
            }
            Console.WriteLine(res);
        }
        public static void summ()
        {
            int n = 1234;
            int sum = 0;
            while(n!=0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        public static void occurence()
        {
            
            Console.WriteLine("enter any string");
            string str = Console.ReadLine();
            while(str.Length>0)
            {
                int count = 0;
                Console.Write(str[0] + " ");
                for (int i=0;i<=str.Length-1;i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.Write(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            
            }
        }
    }
}
