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
    public partial class ResultDataControl : UserControl
    {
        private ResultData _resultData;

        public ResultData ResultData 
        { 
            set
            {
                _resultData = value;
                integralResultDataControl1.CalculationResult = value;

            }
        }
        public ResultDataControl()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            table.Columns.Add("Угол", typeof(float));
            table.Columns.Add("Интенсивность", typeof(float));
            table.Columns.Add("S11", typeof(float));
            table.Columns.Add("S33", typeof(float));
            table.Columns.Add("S34", typeof(float));

            ResultDataGridView.DataSource = table;
        }

    }
}
