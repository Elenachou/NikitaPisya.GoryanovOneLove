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

        public string SomeValue
        {
            get 
            {
                return WavelengthTB.Text;
            }
            
        }
    }
    
}
