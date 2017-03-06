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
            // A simple Do While Loop which shows the variable x every time it executes until it reaches 5
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
