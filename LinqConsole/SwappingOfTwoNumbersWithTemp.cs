using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class SwappingOfTwoNumbersWithTemp
    {
        static int temp;
        public static void swap()
        {
            Console.WriteLine("enter any two numbers");
            int x=Int32.Parse(Console.ReadLine());
            int y=Int32.Parse(Console.ReadLine());
            Console.WriteLine("the numbers before swapping:"+x+""+y);
            temp=x;
            x=y;
            y=temp;
            Console.WriteLine("the numbers after swapping:" + x + "" + y);
        }
    }
}
