using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
public void SimpleCalculator(double x, double y)
{

    Operation operation = this.cView.GetInput();
    IsEligable(operation);
    double result;

    switch (operation)
    {
        case Operation.plus:
            result = Add(x, y);
            this.cView.PresentResult(result);
            break;
        case Operation.minus:
            result = Subtract(x, y);
            this.cView.PresentResult(result);
            break;
        case Operation.multiply:
            result = Multiply(x, y);
            this.cView.PresentResult(result);
            break;
        case Operation.divide:
            result = Divide(x, y);
            this.cView.PresentResult(result);
            break;
    }
}