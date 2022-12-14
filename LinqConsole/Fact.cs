using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Fact
    {
       static int fact = 1;
        public static void factorial()
        {
            Console.WriteLine("enter any number");
            int num=Int32.Parse(Console.ReadLine());
            for(int i=1;i<=num; i++)
            {
                fact *= i;
                
            }
            Console.WriteLine(fact);
        }
    }
}
