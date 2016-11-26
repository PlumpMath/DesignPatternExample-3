using System;

namespace DesignPatternExample.Strategy
{
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(double moneyCondition,double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public override double acceptCash(double money)
        {
            double result = money;

            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }

            return result;
        }
    }
}
