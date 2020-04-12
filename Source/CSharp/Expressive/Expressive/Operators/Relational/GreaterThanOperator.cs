﻿using Expressive.Expressions;
using Expressive.Expressions.Binary.Relational;

namespace Expressive.Operators.Relational
{
    internal class GreaterThanOperator : OperatorBase
    {
        #region OperatorBase Members

        public override string[] Tags => new[] { ">" };

        public override IExpression BuildExpression(Token previousToken, IExpression[] expressions, Context context)
        {
            return new GreaterThanExpression(expressions[0], expressions[1], context);
        }

        public override OperatorPrecedence GetPrecedence(Token previousToken)
        {
            return OperatorPrecedence.GreaterThan;
        }

        #endregion
    }
}
