using System;

namespace DesignPatternExample.Decorator
{
    public  class Tie:Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("系领带");
        }
    }
}
