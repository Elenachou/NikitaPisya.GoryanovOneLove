﻿using System;
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
            resControl1.ResultData = result;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Serializer.Serialize(initialDataControl1.InitialData, "c:\");
        }

        private void resControl1_Load(object sender, EventArgs e)
        {

        }

        private void initialDataControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
