using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MieCalc
{
    public partial class MieCalcForm : Form
    {
        public MieCalcForm()
        {
            InitializeComponent();
            var initialData = new InitialData();
            initialDataControl1.InitialData = initialData;
            initialDataControl1.Calculated += initialDataControl1_Calculated;
        }

        void initialDataControl1_Calculated(object sender, EventArgs e)
        {
            var result = initialDataControl1.ResultData;
            outputControl1.CalculationResult = result;
        }
    }
}
