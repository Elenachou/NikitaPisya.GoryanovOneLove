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
    public partial class IntegralResultDataControl : UserControl
    {
        public ResultData CalculationResult
        {
            set
            {
                DiffractionParameterTextBox.Text = value.DiffractionParameter.ToString();
            }
        }


        public IntegralResultDataControl()
        {
            InitializeComponent();
        }
    }
}
