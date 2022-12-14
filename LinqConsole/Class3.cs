using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Class3
    {
        static int p1 = 0, p2 = 1, p3 = 0;
        public static void fibo()
        {
            Console.WriteLine("ENTER A NUMBER");
            int series=Int32.Parse(Console.ReadLine());
            for(int i=0;i<series;i++)
            {
                p3 = p1 + p2;
                Console.Write(p3);
                p1 = p2;
                p2= p3;
            }
            Console.WriteLine();
        }
        
    }
}
