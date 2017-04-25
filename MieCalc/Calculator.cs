using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieCalc
{
    public static class Calculator
    {
        public static CalculationResult Calculate(double wavelength, double rangeMin, double rangeMax, double steps, double numberOfDiscs, double relativeHumidity)
        {
            var refMed = 1;
            return new CalculationResult()
            {
                 diffractionParametr = 2 * Math.PI * rangeMin * refMed / wavelength,

            };
        }
    }
}
