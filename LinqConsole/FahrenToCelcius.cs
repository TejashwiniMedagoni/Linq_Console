using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class FahrenToCelcius
    {
        public static void ToCelsius()
        {
            Console.WriteLine("enter fahrenheat");
            double fahren=double.Parse(Console.ReadLine());
            double celsius = (fahren - 32) * 5 / 9;
            Console.WriteLine(celsius);
        }
    }
}
