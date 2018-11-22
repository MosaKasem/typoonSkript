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
        public double SimpleCalculator(double x, double y)
        {
            Operation operation = GetInput();
            double result;
            if (operation == Operation.plus) {
                result = Add(x, y);
                return result;
            }
            if (operation == Operation.minus) {
                result = Subtract(x, y);
                return result;
            }
            return 0;
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
        }/*
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

        public double Elevate(ICalculator values, double x, double y)
        {
            var value = values.Elevated(x, y);
            return value;
        }
        public double Elevated(double x, double y)
        {
            return Math.Pow(x, y);
        } */
        public Operation GetInput()
        {
            switch (System.Console.In.Read())
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
