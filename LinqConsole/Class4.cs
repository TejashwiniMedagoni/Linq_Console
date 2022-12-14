using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Class4
    {
       
        public static void fact()
        {
            int fact = 1;
            Console.WriteLine("enter the digit");
            int num=Int32.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
