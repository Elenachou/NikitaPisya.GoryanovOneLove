using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Office.Interop.Excel;
using MieCalc;


namespace MieCalc
{

    /// <summary>
    /// 
    /// </summary>
    public static class ExcelExporter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialData"></param>
        /// <param name="resultData"></param>
        public static void Export(InitialData initialData, ResultData resultData, System.Data.DataTable  table )
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            // Создание экземпляра книги
            Workbook wb = Excel.Workbooks.Add(Type.Missing);

            // Определение количества страниц
            Excel.SheetsInNewWorkbook = 5;
            
            // Наименование листов

            (Excel.Sheets[1] as Worksheet).Name = "Пыль";
            (Excel.Sheets[2] as Worksheet).Name = "B1-Аэрозоль+Вода";
            (Excel.Sheets[3] as Worksheet).Name = "Соль+Вода(0.24)";
            (Excel.Sheets[4] as Worksheet).Name = "Соль+Вода(2.00)";
            //(Excel.Sheets[5] as Worksheet).Name = "Исходные данные";

            // Наименование заголовков таблиц
            (Excel.Sheets[1] as Worksheet).Cells[1, 1] = "Угол";
            (Excel.Sheets[1] as Worksheet).Cells[1, 2] = "Интенсивность";
            (Excel.Sheets[1] as Worksheet).Cells[1, 3] = "S11";
            (Excel.Sheets[1] as Worksheet).Cells[1, 4] = "S33";
            (Excel.Sheets[1] as Worksheet).Cells[1, 5] = "S34";

            (Excel.Sheets[2] as Worksheet).Cells[1, 1] = "Угол";
            (Excel.Sheets[2] as Worksheet).Cells[1, 2] = "Интенсивность";
            (Excel.Sheets[2] as Worksheet).Cells[1, 3] = "S11";
            (Excel.Sheets[2] as Worksheet).Cells[1, 4] = "S33";
            (Excel.Sheets[2] as Worksheet).Cells[1, 5] = "S34";

            (Excel.Sheets[3] as Worksheet).Cells[1, 1] = "Угол";
            (Excel.Sheets[3] as Worksheet).Cells[1, 2] = "Интенсивность";
            (Excel.Sheets[3] as Worksheet).Cells[1, 3] = "S11";
            (Excel.Sheets[3] as Worksheet).Cells[1, 4] = "S33";
            (Excel.Sheets[3] as Worksheet).Cells[1, 5] = "S34";

            (Excel.Sheets[4] as Worksheet).Cells[1, 1] = "Угол";
            (Excel.Sheets[4] as Worksheet).Cells[1, 2] = "Интенсивность";
            (Excel.Sheets[4] as Worksheet).Cells[1, 3] = "S11";
            (Excel.Sheets[4] as Worksheet).Cells[1, 4] = "S33";
            (Excel.Sheets[4] as Worksheet).Cells[1, 5] = "S34";

            //(Excel.Sheets[5] as Worksheet).Cells[1, 1] = "Минимальный диапозон радиусов частиц";
            //(Excel.Sheets[5] as Worksheet).Cells[1, 2] = "Максимальный диапозон радиусов частиц";
            //(Excel.Sheets[5] as Worksheet).Cells[1, 3] = "Длина волны";
            //(Excel.Sheets[5] as Worksheet).Cells[1, 4] = "Число дискретов по углу между 0 и 90";
            //(Excel.Sheets[5] as Worksheet).Cells[1, 5] = "Относительная влажность";
            //(Excel.Sheets[5] as Worksheet).Cells[1, 6] = "Шаг";

            Excel.Visible = true;



           ///////////////////////////////////////////////////////////////////////СЕЧЕНИЕ 

            for (int j = 2; j <= table.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    (Excel.Sheets[1] as Worksheet).Cells[j, i] = table.Rows[j - 2][i - 1].ToString();
                }
            }

            for (int j = 2; j <= table.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    (Excel.Sheets[2] as Worksheet).Cells[j, i] = table.Rows[j - 2][i-1].ToString();
                }
            }

            for (int j = 2; j <= table.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    (Excel.Sheets[3] as Worksheet).Cells[j, i] = table.Rows[j - 2].ItemArray[i - 1];
                }
            }

            for (int j = 2; j <= table.Rows.Count + 1; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    (Excel.Sheets[4] as Worksheet).Cells[j, i] = table.Rows[j - 2].ItemArray[i - 1];
                }
            }

            (Excel.Sheets[5] as Worksheet).Cells[1, 1] = initialData.RangeMin;
            (Excel.Sheets[5] as Worksheet).Cells[1, 2] = initialData.RangeMax;
            (Excel.Sheets[5] as Worksheet).Cells[1, 3] = initialData.WaveLength;
            (Excel.Sheets[5] as Worksheet).Cells[1, 4] = initialData.DiscretsCount;
            (Excel.Sheets[5] as Worksheet).Cells[1, 5] = initialData.RelativeHumidity;
            (Excel.Sheets[5] as Worksheet).Cells[1, 6] = initialData.Steps;

        }
    }
}