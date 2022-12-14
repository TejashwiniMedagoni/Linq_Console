using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
     class Overrideclass
    {
        public  virtual void manasa()
        {
            Console.WriteLine("aaa");
        }

    }
    class B: Overrideclass
    {
        public  override void manasa()
        {
            Console.WriteLine("bbbb");
        }
    }
}
