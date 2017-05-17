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


        public event EventHandler Calculated;

        public InitialData InitialData
        {
            set
            {
                _initialData = value;
                WavelengthTB.Text = _initialData.WaveLength.ToString();
                StepsTB.Text = _initialData.Steps.ToString();
                RangeMaxTB.Text = _initialData.RangeMax.ToString();
                RangeMinTB.Text = _initialData.RangeMin.ToString();
            }
            get
            {
                _initialData.WaveLength = Convert.ToDouble(WavelengthTB.Text);
                _initialData.Steps = Convert.ToInt32(StepsTB.Text);

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
            InitializeComponent();
        }

        private void Calculate()
        {

            _resultData = Calculator.Calculate(InitialData);
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
    }

}

