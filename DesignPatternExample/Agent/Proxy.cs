namespace DesignPatternExample.Agent
{
  public  class Proxy : IGiveGift
    {
        Pursuit pursuer;

        public Proxy(Girl girl)
        {
            pursuer = new Pursuit(girl);
        }

        public void GiveChocolate()
        {
            pursuer.GiveChocolate();
        }

        public void GiveDolls()
        {
            pursuer.GiveDolls();
        }

        public void GiveFlowers()
        {
            pursuer.GiveFlowers();
        }
    }
}
