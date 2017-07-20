package com.bijington.expressive.functions.mathematical;

import com.bijington.expressive.exceptions.ExpressiveException;
import com.bijington.expressive.expressions.IExpression;
import com.bijington.expressive.functions.FunctionBase;

/**
 * Created by shaun on 12/07/2016.
 */
public class AsinFunction extends FunctionBase {
    @Override
    public String getName() {
        return "Asin";
    }

    @Override
    public Object evaluate(IExpression[] parameters) throws ExpressiveException {
        this.validateParameterCount(parameters, 1, 1);

        Object value = parameters[0].evaluate(this.getVariables());

        if (value == null) return null;

        if (value.getClass().equals(Integer.class)) {
            return Math.asin(Integer.class.cast(value));
        }
        else if (value.getClass().equals(Long.class)) {
            return Math.asin(Long.class.cast(value));
        }
        else if (value.getClass().equals(Double.class)) {
            return Math.asin(Double.class.cast(value));
        }
        else if (value.getClass().equals(Float.class)) {
            return Math.asin(Float.class.cast(value));
        }

        return null;
    }
}
