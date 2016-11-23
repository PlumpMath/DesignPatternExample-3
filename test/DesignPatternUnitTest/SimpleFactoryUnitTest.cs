using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternExample.SimpleFactory;

namespace DesignPatternUnitTest
{
    [TestClass]
    public class SimpleFactoryUnitTest
    {
        [TestMethod]
        public void SimpleFactoryTestMethod()
        {
            Operation oper = null;
            double numA = 99;
            double numB = 9.9;

            oper = OperationFactory.CreateOperate(OperationType.ADD);
            oper.NumberA = numA;
            oper.NumberB = numB;
            Assert.AreEqual(typeof(OperationAdd), oper.GetType());
            Assert.AreEqual(numA + numB, oper.GetResult());

            oper = OperationFactory.CreateOperate(OperationType.SUB);
            oper.NumberA = numA;
            oper.NumberB = numB;
            Assert.AreEqual(typeof(OperationSub), oper.GetType());
            Assert.AreEqual(numA - numB, oper.GetResult());

            oper = OperationFactory.CreateOperate(OperationType.MUL);
            oper.NumberA = numA;
            oper.NumberB = numB;
            Assert.AreEqual(typeof(OperationMul), oper.GetType());
            Assert.AreEqual(numA * numB, oper.GetResult());

            oper = OperationFactory.CreateOperate(OperationType.DIV);
            oper.NumberA = numA;
            oper.NumberB = numB;
            Assert.AreEqual(typeof(OperationDiv), oper.GetType());
            Assert.AreEqual(numA / numB, oper.GetResult());
        }
    }
}
