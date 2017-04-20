using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class IntialDateControl : UserControl
    {
        public IntialDateControl()
        {
            InitializeComponent();
        }

        /* public string SomeValue
         {
             get 
             {
                 return WavelengthTB.Text;   
             }
             set
             {
                 Wavelength.Text = value;
             }
         }
         *  проблема в чём,я тут поняла, что кнопка расчёт нах-ся на этом же контроле 
         и не нужно передавать значения textBox-ов на главную форму . 
         * При нажатии кнопки будут рассчитываться данные, и заполняться таблица и Контрол снизу.
         * Я правильно думаю?
 */

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            var wavelength = WavelengthTB.Text;

        }
    }
    
}
