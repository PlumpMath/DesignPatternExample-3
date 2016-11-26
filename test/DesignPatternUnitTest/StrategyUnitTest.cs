using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternExample.Strategy;

namespace DesignPatternUnitTest
{
    [TestClass]
    public class StrategyUnitTest
    {
        [TestMethod]
        public void CashNormalStrategyTestMethod()
        {
            double money = 999;

            CashContext context = new CashContext(new CashNormal());
            Assert.AreEqual(money, context.GetResule(money));
        }

        [TestMethod]
        public void CashRebateStrategyTestMethod()
        {
            double money = 999;
            
            double rebate = 0.95d;

            CashContext context = new CashContext(new CashRebate(rebate));
            Assert.AreEqual(money * rebate, context.GetResule(money));
        }

        [TestMethod]
        public void CashReturnStrategyTestMethod()
        {
            double money = 999;
            
            double condition = 100d;
            double _return = 10;
            CashContext context = new CashContext(new CashReturn(condition, _return));
            double expected = money < condition ? money : money - Math.Floor(money / condition) * _return;
            Assert.AreEqual(expected, context.GetResule(money));
        }
    }
}
