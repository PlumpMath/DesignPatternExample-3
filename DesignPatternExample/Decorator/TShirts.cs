using System;

namespace DesignPatternExample.Decorator
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("穿大T恤");
        }
    }
}
