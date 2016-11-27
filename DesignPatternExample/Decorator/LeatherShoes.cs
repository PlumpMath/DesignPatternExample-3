using System;

namespace DesignPatternExample.Decorator
{
    public  class LeatherShoes:Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("穿皮鞋");
        }
    }
}
