using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqConsole
{
    internal class ipl
    {
        public static void Teams()
        {
            string[] Name = new string[10] { "GT", "LSG", "RR", "DC", "RCB", "KKR", "PBKS", "SRH", "CSK", "MI" };
            
            string[] Last5 = new string[10] { "01000", "00011", "01010", "11101", "01010", "11001", "01010", "01011", "01010", "00001" };
            
            for (int i = 0; i <= 9; i++)
            {
                char[] c = Last5[i].ToArray();
                for (int j = 1; j <= 4; j++)
                {

                    if (c[j - 1] == c[j] && c[j] == '0')
                    {

                        Console.WriteLine(Name[i] + "     " + Last5[i]);
                        break;
                    }

                }
            }

        }
    }
}
