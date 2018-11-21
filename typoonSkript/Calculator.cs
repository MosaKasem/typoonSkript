using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
using Moq;

namespace Domain
{
    public class Calculator : ICalculator
    {
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

        public double Elevate(ICalculator values)
        {
            return 25;
        }
/*         public double Elevated(double x, double y)
        {
            return Math.Pow(x, y);
        } */
    }

}
