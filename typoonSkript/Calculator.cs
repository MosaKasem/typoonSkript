using System;

namespace Domain
{
    /*     public interface IValue
        {
            bool IsEligable(Operation op);
        } */
    public class Calculator : ConsoleWrapper
    {
        CalculatorView cView;
        private IConsole _console;
        public Calculator(IConsole console, CalculatorView cView)
        {
            this._console = console;
            this.cView = cView;
        }
/*         public bool IsEligable(Operation op)
        {
            // A bug encountered // cannot solve.
            if (op == Operation.plus || op == Operation.minus || op == Operation.divide || op == Operation.multiply)
            {
                return true;
            }
            else
            {
                return false;
            }
        } */
        public virtual void SimpleCalculator(double x, double y, Operation o)
        {  
            double result;
            switch (o)
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
                case Operation.Null:
                    throw new Exception("Invalid Operation");    
            }
        }
        public virtual double Add(double x, double y)
        {
            return x + y;
        }
        public virtual double Subtract(double x, double y)
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
