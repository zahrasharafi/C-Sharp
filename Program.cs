using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoLoop
{
    public class DoWhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While Loop");
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 5);
            Console.ReadKey();
        }
    }
}
