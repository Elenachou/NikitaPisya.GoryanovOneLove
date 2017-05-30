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

        public void FillStringGrid(int numRow, double ANG, double S11r, double S11, double S33, double S34)
        {
            DataTable table = (DataTable) ResultDataGridView.DataSource;
            DataRow workRow = table.NewRow();
            /*
            Grid.Cells[0, J] := FloatToStrF(ANG, ffFixed, 3, 0);
            Grid.Cells[1, J] := FloatToStrF(S11r, ffFixed, 6, 6)
            Grid.Cells[2, J] := FloatToStrF(S11, ffFixed, 6, 6);
            Grid.Cells[3, J] := FloatToStrF(S33, ffFixed, 6, 6);
            Grid.Cells[4, J] := FloatToStrF(S34, ffFixed, 6, 6);
            Grid.RowCount := J + 1; */
            workRow[0] = ANG.ToString();
            workRow[1] = S11r.ToString();
            workRow[2] = S11.ToString();
            workRow[3] = S33.ToString();
            workRow[4] = S34.ToString();
            table.Rows.Add(workRow);
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

        private void ResultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
