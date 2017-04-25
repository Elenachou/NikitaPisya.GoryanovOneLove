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
    public partial class OutputControl : UserControl
    {
        public OutputControl()
        {
            InitializeComponent();
        }
        double x;

        private void DiffractionParameterTB_TextChanged(object sender, EventArgs e) //Показатель дифракции
        {
            //if (IntialDateControl.DialogResult != DialogResult.Cancel)
            //{
            //    x = 2 * Math.PI * rangeMin * refMed / wavelength;
            //    diffractionParameterTB.Text = Convert.ToString(x, 4, 4) ;// Конвертировать.............\

            //}
        }

        private void RefractiveIndexTB_TextChanged(object sender, EventArgs e) // Показатель преломления
        {

        }

    }
}
