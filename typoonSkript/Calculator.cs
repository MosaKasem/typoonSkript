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
        public double SimpleCalculator(string operation, double x, double y)
        {
            double result;
            if (operation == "+") {
                double value = Add(x, y);
                return value;
            }
            return 0;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
/*         public double Subtract(double x, double y)
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

        public double Elevate(ICalculator values, double x, double y)
        {
            var value = values.Elevated(x, y);
            return value;
        }
        public double Elevated(double x, double y)
        {
            return Math.Pow(x, y);
        } */
    }

}
