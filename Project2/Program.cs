using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program:FirstClass.Program
    {
        static void Main(string[] args)
        {
            Program c1 = new Program();
            c1.ProtectedInternalMethod();
            c1.ProtectedMethod();
            c1.PublicMethod();
        }
    }
}
