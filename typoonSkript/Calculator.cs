using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
using Moq;

namespace Domain
{
    public class Calculator
    {
        private readonly IStore store;
        public Calculator(IStore store)
        {
            this.store = store;
        }
        public int Add(int input)
        {
            this.store.Save(input);
            return input;
        }
        public double SimpleCalculator(double x, double y)
        {
            Operation operation = GetInput();
            double result;

            switch (operation)
            {
                case Operation.plus:
                    result = Add(x, y);
                    return result;
                case Operation.minus:
                    result = Subtract(x, y);
                    return result;
                case Operation.multiply:
                    result = Multiply(x, y);
                    return result;
                case Operation.divide:
                    result = Divide(x, y);
                    return result;
                    default:
                    return 0;
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
        public Operation GetInput()
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
        }
    }

}
