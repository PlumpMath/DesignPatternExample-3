using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Decorator
{
    public class Person
    {
        private string name;

        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }
                
        public virtual void Show()
        {
            Console.WriteLine($"{name}的装扮");
        }
    }
}
