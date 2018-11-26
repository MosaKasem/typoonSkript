using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Domain
{
    public interface IValue
    {
        bool IsEligable(Operation op);
    }
    public class Calculator : IValue
    {
        CalculatorView cView;
        public Calculator(CalculatorView cView)
        {
            this.cView = cView;
        }
        public bool IsEligable(Operation op)
        {
            throw new Exception();
/*             if (op == Operation.plus || op == Operation.minus || op == Operation.divide || op == Operation.multiply)
            {
                return true;
            } else {
                return false;
            } */
        }
        public void SimpleCalculator(double x, double y)
        {
            Operation operation = this.cView.GetInput();
            while(operation != Operation.Null)
            try
            {
                IsEligable(operation);
            }
            catch (System.Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
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
/*                 default:
                    return 0; */
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
/*         public Operation GetInput()
        {
            string x = Console.ReadLine();
            switch (x.ToCharArray()[0])
            {
                case '+':
                    return Operation.plus;
                case '-':
                    return Operation.minus;
                case '*':
                    return Operation.multiply;
                case '/':
                    return Operation.divide;
                default:
                    return Operation.Null;
            }
        } */
    }

}
