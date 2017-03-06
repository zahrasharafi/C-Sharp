using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    public class WhileLoop
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n++ < 6)
            {
                Console.WriteLine("Current value of n is : {0} ", n);
            }
            Console.ReadKey();
        }
    }
}
