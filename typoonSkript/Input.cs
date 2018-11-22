using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Input
    {
        public double UserInput(string input)
        {
            if (!double.TryParse(input, out double convertedNumber)) { return 0; }
            return convertedNumber;
        }
    }
}