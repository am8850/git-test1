using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
                Console.WriteLine("This is a test " + i.ToString());

            Console.ReadLine();
        }
    }
}
