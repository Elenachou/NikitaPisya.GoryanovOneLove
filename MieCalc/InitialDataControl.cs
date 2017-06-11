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
                WaveLengthTextBox.Text = _initialData.WaveLength.ToString();
                StepsTextBox.Text = _initialData.Steps.ToString();
                RangeMaxTextBox.Text = _initialData.RangeMax.ToString();
                RangeMinTextBox.Text = _initialData.RangeMin.ToString();
            }
            get
            {
                _initialData.WaveLength = Convert.ToDouble(WaveLengthTextBox.Text);
                _initialData.Steps = Convert.ToInt32(StepsTextBox.Text);

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
            _initControlls();
        }

        //Для сохранения данных при выходу
        private void _initControlls()
        {
            
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

