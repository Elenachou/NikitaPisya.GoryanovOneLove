using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MieCalc;


namespace MieCalcTest
{
    public class InitialDataTest
    {
        [Test]
        [TestCase(-1, TestName = "WaveLength. NegativeValue")]
        [TestCase(-2, TestName = "WaveLength. NegativeValue")]
        [TestCase(4, ExpectedException = typeof(ArgumentException), TestName = "WaveLength. PositiveValue")]
        [TestCase(6, ExpectedException = typeof(ArgumentException), TestName = "WaveLength. PositiveValue")]
        public void WaveLengthTest(double waveLength)
        {
            var initialData = new InitialData();
            initialData.WaveLength = waveLength;
        }


        [Test]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "RangeMin. NegativeValue")]
        [TestCase(-2, ExpectedException = typeof(ArgumentException), TestName = "RangeMin. NegativeValue")]
        [TestCase(4,  TestName = "RangeMin. PositiveValue")]
        [TestCase(6, TestName = "RangeMin. PositiveValue")]
        public void RangeMinTest(double rangeMin)
        {
            var initialData = new InitialData();
            initialData.RangeMin = rangeMin;
        }

        [Test]
        [TestCase(-1, TestName = "RangeMax. PositivetiveValue")]
        [TestCase(-2, TestName = "RangeMax. PositivetiveValue")]
        [TestCase(4, ExpectedException = typeof(ArgumentException), TestName = "RangeMax. NegativeValue")]
        [TestCase(6, ExpectedException = typeof(ArgumentException), TestName = "RangeMax. NegativeValue")]
        public void RangeMaxTest(double rangeMax)
        {
            var initialData = new InitialData();
            initialData.RangeMax = rangeMax;
        }

        [Test]
        [TestCase(-1, TestName = "Steps. PositiveValue")]
        [TestCase(-2, TestName = "Steps. PositiveValue")]
        [TestCase(4, ExpectedException = typeof(ArgumentException), TestName = "Steps. NegativeValue")]
        [TestCase(6, ExpectedException = typeof(ArgumentException), TestName = "Steps. NegativeValue")]
        public void StepsTestTest(int steps)
        {
            var initialData = new InitialData();
            initialData.Steps = steps;
        }



    }
}
