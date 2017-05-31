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
                //RefractiveIndexTextBox.Text = value.rd.OptI[I].ToString();
                ScatteringFactorTextBox.Text = value.QSCA.ToString();
                AbsortionFactorTextBox.Text = value.QEXT.ToString();
                BackscatteringFactorTextBox.Text = value.QABS.ToString();

            }
        }

        public IntegralResultDataControl()
        {
            InitializeComponent();
        }
    }
}
