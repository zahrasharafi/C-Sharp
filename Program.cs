using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    public class ForLoop
    {
        static void Main(string[] args)
        {
            int i;
            int j = 10;
            for (i = 0, Console.WriteLine("Start: {0}", i); i < j; i++, j--, Console.WriteLine("i = {0} , j = {1}", i, j))
            {
                //Body of the loop
            }
            Console.ReadKey();
        }
    }
}
