using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Domain
{
/*     public interface IValue
    {
        bool IsEligable(Operation op);
    } */
    public class Calculator
    {
        CalculatorView cView;
        public Calculator(CalculatorView cView)
        {
            this.cView = cView;
        }
        public bool IsEligable(Operation op)
        {
            if (op == Operation.plus || op == Operation.minus || op == Operation.divide || op == Operation.multiply)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }
        public void SimpleCalculator(double x, double y, Operation op)
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
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }
        }
    }

}
