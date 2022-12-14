using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class CelsiusToFahren
    {
        public static void ToFahren()
        {
            Console.WriteLine("enter celsius");
            double celsius=double.Parse(Console.ReadLine());
            double fahren = ((celsius * 9) / 5) + 32;
            Console.WriteLine(fahren);
        }
    }
}
