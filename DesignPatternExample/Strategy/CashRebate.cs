namespace DesignPatternExample.Strategy
{
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
