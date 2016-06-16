﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions
{
    internal class ExpFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "Exp"; } }

        public override object Evaluate(IExpression[] parameters)
        {
            this.ValidateParameterCount(parameters, 1, 1);

            return Math.Exp(Convert.ToDouble(parameters[0].Evaluate(Variables)));
        }

        #endregion
    }
}
