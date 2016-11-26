using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternExample.FactoryMethod;

namespace DesignPatternUnitTest
{
    [TestClass]
    public class FactoryMethodUnitTest
    {
        [TestMethod]
        public void OperationAddTestMethod()
        {
            IFactory factory = new AddFactory();
            var operation = factory.CreateOperation();
            operation.NumberA = 99;
            operation.NumberB = 10;
            var result = operation.GetResult();

            Assert.AreEqual(99 + 10, result);
        }

        [TestMethod]
        public void OperationSubTestMethod()
        {
            IFactory factory = new SubFactory();
            var operation = factory.CreateOperation();
            operation.NumberA = 99;
            operation.NumberB = 10;
            var result = operation.GetResult();

            Assert.AreEqual(99 - 10, result);
        }

        [TestMethod]
        public void OperationMulTestMethod()
        {
            IFactory factory = new MulFactory();
            var operation = factory.CreateOperation();
            operation.NumberA = 99;
            operation.NumberB = 10;
            var result = operation.GetResult();

            Assert.AreEqual(99 *10, result);
        }

        [TestMethod]
        public void OperationDivTestMethod()
        {
            IFactory factory = new DivFactory();
            var operation = factory.CreateOperation();
            operation.NumberA = 99;
            operation.NumberB = 10;
            var result = operation.GetResult();

            Assert.AreEqual(99d / 10, result);
        }
    }
}
