using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Revword
    {
        public static void reverseword()
        {
            Console.WriteLine("enter any string");
            string str=Console.ReadLine();

            string rev = string.Join(" ",str.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(rev);
        }
           
    }
   

    }

