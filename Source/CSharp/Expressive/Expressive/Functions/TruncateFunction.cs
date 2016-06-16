﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions
{
    internal class TruncateFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "Truncate"; } }

        public override object Evaluate(IExpression[] parameters)
        {
            this.ValidateParameterCount(parameters, 1, 1);

            return Math.Truncate(Convert.ToDouble(parameters[0].Evaluate(Variables)));
        }

        #endregion
    }
}
