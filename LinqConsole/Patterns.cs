using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Patterns
    {
        public static void pattern()
        {
            Console.WriteLine("enter no.of rows");
            int rows=int.Parse(Console.ReadLine());
            for(int i=1;i<=rows;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine( );
            }
        }
    }
}
