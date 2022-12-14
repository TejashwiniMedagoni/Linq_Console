using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class SwappingWithoutTemp
    {
        public static void swap()
        {
            Console.WriteLine("enter two numbers");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("the numbers before swapping:" + x + " " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("the numbers after swapping:"+x+" "+y);
        }
    }
}
