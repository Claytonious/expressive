﻿using System.Collections.Generic;
using Expressive.Expressions;
using Expressive.Expressions.Binary.Relational;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Expressive.Tests.Expressions.Binary.Relational
{
    [TestClass]
    public class EqualExpressionTests
    {
        [TestMethod]
        public void TestBothNull()
        {
            var expression = new EqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                new Context(ExpressiveOptions.None));

            Assert.AreEqual(true, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestEqual()
        {
            var expression = new EqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)5),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)5),
                new Context(ExpressiveOptions.None));

            Assert.AreEqual(true, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestLeftNull()
        {
            var expression = new EqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)"abc"),
                new Context(ExpressiveOptions.None));

            Assert.AreEqual(false, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestNotEqual()
        {
            var expression = new EqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)5),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)2),
                new Context(ExpressiveOptions.None));

            Assert.AreEqual(false, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestRightNull()
        {
            var expression = new EqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)false),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                new Context(ExpressiveOptions.None));

            Assert.AreEqual(false, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestIntFloatUnequal()
        {
            var expression = new EqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)1),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)1.001),
                new Context(ExpressiveOptions.None));

            Assert.AreEqual(false, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestIntFloatEqual()
        {
            var expression = new EqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)1),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)1.00),
                new Context(ExpressiveOptions.None));

            Assert.AreEqual(true, expression.Evaluate(null));
        }
    }
}
