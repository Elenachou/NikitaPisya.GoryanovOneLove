using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieCalc
{
    public static class Calculator
    {
        public static CalculationResult Calculate()
        {
            return new CalculationResult()
            {
                Results = new List<double> { 0.1, 0.2, 0.3 }
            };
        }
    }
}
