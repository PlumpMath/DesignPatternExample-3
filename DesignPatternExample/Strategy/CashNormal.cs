namespace DesignPatternExample.Strategy
{
    public class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
