using System;

namespace DesignPatternExample.Decorator
{
    public  class Suit:Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("穿西装");
        }
    }
}
