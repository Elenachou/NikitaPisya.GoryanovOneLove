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
        private CalculationResult _calculationResult;

        public event EventHandler Calculated;

        public CalculationResult CalculationResult
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

        //public string SomeValue
        //{
        //    get
        //    {
        //        return WavelengthTB.Text;
        //    }
        //    set
        //    {
        //        WavelengthTB.Text = value;
        //    }
        //}

        //public double Foo
        //{
        //    get
        //    {
        //        return Convert.ToDouble(WavelengthTB.Text);
        //    }
        //    set
        //    {
        //        WavelengthTB.Text = value.ToString();
        //    }
        //}
        /*  проблема в чём,я тут поняла, что кнопка расчёт нах-ся на этом же контроле 
         и не нужно передавать значения textBox-ов на главную форму . 
         * При нажатии кнопки будут рассчитываться данные, и заполняться таблица и Контрол снизу.
         * Я правильно думаю?
 */

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            var wavelength = WavelengthTB.Text;                 // Так?
            var steps = StepsTB.Text;
            var numberOfDiscs = NumberOfDiscsTB.Text;
            var relativeHumidityTB = RelativeHumidityTB.Text;
            var rangeMaxTB = RangeMaxTB.Text;
            var rangeMin = RangeMinTB.Text;



        }

        private void Calculate()
        {
            _calculationResult = Calculator.Calculate();
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

