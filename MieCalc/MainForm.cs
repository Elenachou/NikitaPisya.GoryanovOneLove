using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MieCalc
{
    public partial class MieCalcForm : Form
    {
        InitialData _initialData = null;
        ResultDataControl resultDataControl = new ResultDataControl();
        public MieCalcForm()
        {
            InitializeComponent();
            var initialData = new InitialData();
            initialDataControl1.InitialData = initialData;
            initialDataControl1.Calculated += initialDataControl1_Calculated;

            _initialData = InitialData.GetInitialData();

         
        }


        void initialDataControl1_Calculated(object sender, EventArgs e)
        {
            var result = initialDataControl1.ResultData;
            resControl1.ResultData = result;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _initialData = initialDataControl1.InitialData;
            _initialData.Save();
        }




        private void экспортироватьВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(Type.Missing);
            Excel.SheetsInNewWorkbook = 4;
            (Excel.Sheets[1] as Worksheet).Name = "Пыль";
            (Excel.Sheets[2] as Worksheet).Name = "B1-Аэрозоль+Вода";
            (Excel.Sheets[3] as Worksheet).Name = "Соль+Вода(0.24)";
            (Excel.Sheets[4] as Worksheet).Name = "Соль+Вода(2.00)";

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Угол";
            ws.Cells[1, 2] = "Интенивность";
            ws.Cells[1, 3] = "S11";
            ws.Cells[1, 4] = "S33";
            ws.Cells[1, 5] = "S34";



            for (int j = 2; j <= resControl1.ResultDataGridView.Rows.Count+1; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    ws.Cells[j, i] = resControl1.ResultDataGridView.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }
    }
}
