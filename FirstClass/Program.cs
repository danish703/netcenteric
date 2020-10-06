using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Program
    {
       
       
        static void Main(string[] args)
        {
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int a = 10 / x;

            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error =" + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zero division error =" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("final code executed");
            }
            Console.ReadLine();
        }
    }
}
