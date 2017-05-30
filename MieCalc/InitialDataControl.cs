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
        private ResultData _resultData;
        private InitialData _initialData;
        private Calculator _calculator;

        public event EventHandler Calculated;

        public InitialData InitialData
        {
            set
            {
                _initialData = value;
                WaveLengthTextBox.Text = _initialData.WaveLength.ToString();
                StepsTextBox.Text = _initialData.Steps.ToString();
                RangeMaxTextBox.Text = _initialData.RangeMax.ToString();
                RangeMinTextBox.Text = _initialData.RangeMin.ToString();
                DiscretsCountTextBox.Text = _initialData.DiscretsCount.ToString();
                RelativeHumidityTextBox.Text = _initialData.RelativeHumidity.ToString();

            }
            get
            {
                _initialData.WaveLength = Convert.ToDouble(WaveLengthTextBox.Text);
                _initialData.Steps = Convert.ToInt32(StepsTextBox.Text);
                _initialData.RangeMax = Convert.ToDouble(RangeMaxTextBox.Text);
                _initialData.RangeMin = Convert.ToDouble(RangeMinTextBox.Text);
                _initialData.DiscretsCount = Convert.ToInt32(DiscretsCountTextBox.Text);
                _initialData.RelativeHumidity = Convert.ToDouble(RelativeHumidityTextBox.Text);
                return _initialData;
            }
        }

        public ResultData ResultData
        {
            get
            {
                return _resultData;
            }
        }

        public InitialDataControl()
        {
            _calculator = new Calculator();
            InitializeComponent();
        }

        private void Calculate()
        {
            _resultData = _calculator.Calculate(InitialData);
        }

        private void CalculationButton_Click_1(object sender, EventArgs e)
        {
            Calculate();
            if (Calculated != null)
            {
                Calculated(this, EventArgs.Empty);
            }
        }

        private void WavelengthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {

            }
        }

        private void RangeMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerpendicularRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}

