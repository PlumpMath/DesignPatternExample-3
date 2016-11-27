using System;

namespace DesignPatternExample.Agent
{
    public class Pursuit : IGiveGift
    {
        Girl girl;

        public Pursuit(Girl girl)
        {
            this.girl = girl;
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{girl.Name}，送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{girl.Name}，送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{girl.Name}，送你鲜花");
        }
    }
}
