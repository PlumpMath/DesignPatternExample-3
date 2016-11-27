using System;

namespace DesignPatternExample.Decorator
{
    public class Sneakers:Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("穿破球鞋");
        }
    }
}
