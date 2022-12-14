using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class single
    {
       
            public static void sin()
            {
            //Sequence contains more than one element
            // List<int> numbers = new List<int>() { 10, 20, 30 };
            //int number = numbers.Single();
            //Console.WriteLine(number);
            //Console.ReadLine();
            List<int> numbers = new List<int>() { 10, 20, 30 };
            int number = numbers.Single(num => num == 20);
            Console.WriteLine(number);
            Console.ReadLine();
        }
        }
    }
