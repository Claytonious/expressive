﻿using System.Collections.Generic;
using Expressive.Expressions;
using Expressive.Expressions.Binary.Relational;
using Moq;
using NUnit.Framework;

namespace Expressive.Tests.Expressions.Binary.Relational
{
    public static class NotEqualExpressionTests
    {
        [TestCase(null, null, false)]
        [TestCase(5, 5, false)]
        [TestCase(5, 2, true)]
        [TestCase(2, 5, true)]
        [TestCase(null, "abc", true)]
        [TestCase("abc", null, true)]
        [TestCase("abc", "abc", false)]
        [TestCase(null, false, true)]
        [TestCase(false, null, true)]
        [TestCase(true, false, true)]
        [TestCase(true, true, false)]
        [TestCase(false, false, false)]
        [TestCase(false, true, true)]
        [TestCase(1.001, 1, true)]
        [TestCase(1, 1.001, true)]
        [TestCase(1.001, 1.001, false)]
        [TestCase(1, 1.00, false)]
        [TestCase(1.00, 1, false)]
        public static void TestEvaluate(object lhs, object rhs, object expectedValue)
        {
            var expression = new NotEqualExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == lhs),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == rhs),
                new Context(ExpressiveOptions.None));

            Assert.That(expression.Evaluate(null), Is.EqualTo(expectedValue));
        }
    }
}
