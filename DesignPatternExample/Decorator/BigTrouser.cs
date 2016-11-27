using System;

namespace DesignPatternExample.Decorator
{
    public  class BigTrouser:Finery
    {
        public override void Show()
        {
            base.Show();

            Console.WriteLine("穿垮裤");
        }
    }
}
