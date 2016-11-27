using DesignPatternExample.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class ProxyTester
    {
        public void Run()
        {
            Girl girl = new Girl();
            girl.Name = "漂亮的MM";

            Proxy proxy = new Proxy(girl);
            proxy.GiveFlowers();
            proxy.GiveDolls();
            proxy.GiveChocolate();
        }
    }
}
