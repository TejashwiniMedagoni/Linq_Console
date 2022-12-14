using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
 class EvenLinque
    {
        
           public static void Main1()
            {
                List<int> listint = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                var listodd = listint.Where(x => x % 2 != 0).ToList();
                var listeven = listint.Where(x => x % 2 == 0).ToList();

            Console.WriteLine("---Printing odd numbers----\n");
            string cssodd = string.Join(",", listodd);
            Console.Write(listodd);

                Console.WriteLine("\n\n---Printing even numbers----\n");
                string csseven = string.Join(",", listeven);
                Console.Write(csseven);
                Console.ReadKey();

            }
        public static void even()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res=(from obj in arr where obj%2==0 select obj).ToList();
            foreach(var items in res)
            Console.WriteLine(items);
        }
        }
    
    }


