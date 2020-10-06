using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
   abstract class AbstractclassDemo
    {

        public AbstractclassDemo() { }
        public void Method1() {
            Console.WriteLine("method 1");
        }

        public abstract void xyz();

        public abstract void zyc();
    }
}
