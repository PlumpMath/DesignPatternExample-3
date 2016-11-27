using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorator decorator = new Decorator();
            decorator.Run();

            Console.Read();
        }
    }
}
