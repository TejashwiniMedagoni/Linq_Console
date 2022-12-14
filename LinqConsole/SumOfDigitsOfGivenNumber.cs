using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class SumOfDigitsOfGivenNumber
    {
       static int sum = 0;
        public static void DigitSum()
        {
            Console.WriteLine("enter any number");
            int num=Int32.Parse(Console.ReadLine());
            while(num!=0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
