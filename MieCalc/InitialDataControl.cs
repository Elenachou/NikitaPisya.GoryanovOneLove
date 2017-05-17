using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MieCalc
{
    public partial class InitialDataControl : UserControl
    {
        private ResultData _calculationResult;

        public event EventHandler Calculated;

        public InitialData InitialData
        {
            set
            {
                wavelength = value.Steps;
                rangeMax = value.Value2;
            }
        }

        public ResultData CalculationResult
        {
            get
            {
                return _calculationResult;
            }
        }

        public InitialDataControl()
        {
            InitializeComponent();
        }

        public double wavelength
        {
            get
            {
                return Convert.ToDouble(WavelengthTB.Text);
            }
            set
            {
                //Задание TextBox значние по умолчанию
                var wv = 0.65;
                WavelengthTB.Text = wv.ToString();
            }
        }
        public double rangeMax
        {
            get
            {
                return Convert.ToDouble(RangeMaxTB.Text);
            }
            set
            {
                RangeMaxTB.Text = value.ToString();
            }
        }

        public double rangeMin
        {
            get
            {
                return Convert.ToDouble(RangeMinTB.Text);
            }
            set
            {
                RangeMinTB.Text = value.ToString();
            }
        }
        public double steps
        {
            get
            {
                return Convert.ToDouble(StepsTB.Text);
            }
            set
            {
                StepsTB.Text = value.ToString();
            }
        }
        public double numberOfDiscs
        {
            get
            {
                return Convert.ToDouble(NumberOfDiscsTB.Text);
            }
            set
            {
                NumberOfDiscsTB.Text = value.ToString();
            }
        }
        public double relativeHumidity
        {
            get
            {
                return Convert.ToDouble(RelativeHumidityTB.Text);
            }
            set
            {
                RelativeHumidityTB.Text = value.ToString();
            }
        }

        private void Calculate()
        {
            _calculationResult = Calculator.Calculate(wavelength,rangeMin,rangeMax,steps,numberOfDiscs, relativeHumidity);
        }

        private void CalculationButton_Click_1(object sender, EventArgs e)
        {
            Calculate();
            if (Calculated != null)
            {
                Calculated(this, EventArgs.Empty);
            }
        }
    }

}

