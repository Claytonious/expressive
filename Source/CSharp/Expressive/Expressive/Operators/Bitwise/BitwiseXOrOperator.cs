﻿using Expressive.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressive.Operators.Bitwise
{
    internal class BitwiseXOrOperator : OperatorBase
    {
        #region OperatorBase Members

        public override string[] Tags { get { return new[] { "^" }; } }

        public override IExpression BuildExpression(string previousToken, IExpression[] expressions)
        {
            return new BinaryExpression(BinaryExpressionType.BitwiseXOr, expressions[0], expressions[1]);
        }

        public override OperatorPrecedence GetPrecedence(string previousToken)
        {
            return OperatorPrecedence.BitwiseXOr;
        }

        #endregion
    }
}