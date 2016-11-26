namespace DesignPatternExample.Strategy
{
    public class CashContext
    {
        CashSuper cash = null;

        public CashContext(CashSuper cash)
        {
            this.cash = cash;
        }

        public double GetResule(double money)
        {
            return cash.acceptCash(money);
        }
    }
}
