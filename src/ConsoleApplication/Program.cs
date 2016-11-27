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
            Console.WriteLine("\n装饰模式----------------\n");

            DecorateTester decorateTest = new DecorateTester();
            decorateTest.Run();

            Console.WriteLine("\n代理模式----------------\n");

            ProxyTester proxyTester = new ProxyTester();
            proxyTester.Run();

            Console.WriteLine("\n原型模式----------------\n");

            PrototypeTester prototypeTester = new PrototypeTester();
            prototypeTester.Run();

            Console.Read();
        }
    }
}
