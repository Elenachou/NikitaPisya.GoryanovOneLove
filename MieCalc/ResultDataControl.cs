using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("Угол", typeof(int));
            table.Columns.Add("Интенсивность", typeof(float));
            table.Columns.Add("S11", typeof(float));
            table.Columns.Add("S33", typeof(float));
            table.Columns.Add("S34", typeof(float));

            //table.Rows.Add(0, 1.000000, 1.000000, 1.000000, 0);
            //table.Rows.Add(1, 2.722620, 0.992570, 0.999999, 0.001360);
            //table.Rows.Add(2, 7.742790, 0.970588, 0.999984, 0.005446);
            //table.Rows.Add(3, 15.630800, 0.934954, 0.999918, 0.012281);
            //table.Rows.Add(4, 25.713600, 0.887106, 0.999739, 0.021900);
            //table.Rows.Add(5, 37.135000, 0.828926, 0.999350, 0.034352);
            //table.Rows.Add(6, 48.931000, 0.762627, 0.998659, 0.049699);
            //table.Rows.Add(7, 60.114300, 0.690618, 0.997488, 0.068010);
            //table.Rows.Add(8, 69.757600, 0.615366, 0.995664, 0.089362);
            //table.Rows.Add(9, 77.070500, 0.539268, 0.992963, 0.113838);
            //table.Rows.Add(10, 81.461700, 0.464524, 0.989123, 0.141520);
            //table.Rows.Add(11, 82.581700, 0.393049, 0.983837, 0.172487);
            //table.Rows.Add(12, 80.344100, 0.326401, 0.976755, 0.206811);
            //table.Rows.Add(13, 74.923000, 0.265742, 0.967481, 0.244551);
            //table.Rows.Add(14, 66.730400, 0.211831, 0.955578, 0.285752);
            //table.Rows.Add(15, 56.374000, 0.165043, 0.940573, 0.330434);
            //table.Rows.Add(16, 44.603200, 0.125407, 0.921969, 0.378574);
            //table.Rows.Add(17, 32.246200, 0.092668, 0.899268, 0.430055);
            //table.Rows.Add(18, 20.144600, 0.066346, 0.872017, 0.484501);
            //table.Rows.Add(19, 9.091890, 0.045812, 0.839924, 0.540801);
            //table.Rows.Add(20, -0.222169, 0.030348, 0.803196, 0.595712);
            //table.Rows.Add(21, -7.255790, 0.019204, 0.763575, 0.639813);
            //table.Rows.Add(22, -11.000000, 0.011645, 0.727516, 0.646287);

            //table.Rows.Add(0, 1.000000, 1.000000, 1.000000, 0);
            ////table.Rows.Add(1, -0.769833, 0.986869, 0.999999, 0.001012);
            ////table.Rows.Add(2, -5.893070, 0.948267, 0.999987, 0.004089);
            ////table.Rows.Add(3, -13.828400, 0.886514, 0.999931, 0.009360);
            ////table.Rows.Add(4,-23.730000, 0.805275, 0.999770, 0.017061);
            ////table.Rows.Add(5, -34.527300, 0.709285, 0.999394, 0.027569);
            ////table.Rows.Add(6, -45.025300, 0.603991, 0.998617, 0.041460);
            ////table.Rows.Add(7, -54.017800, 0.495153, 0.997109, 0.059628);
            ////table.Rows.Add(8, -60.402100, 0.388427, 0.994258, 0.083479);
            ////table.Rows.Add(9, -63.284900, 0.288974, 0.988860, 0.115327);
            ////table.Rows.Add(10, -62.069500, 0.201122, 0.978323, 0.159204);
            ////table.Rows.Add(11, -56.516900, 0.128104, 0.956371, 0.222669);
            ////table.Rows.Add(12, -46.773600, 0.071901, 0.905096, 0.321151);
            ////table.Rows.Add(13, -33.364400, 0.033189, 0.759906, 0.487114);
            ////table.Rows.Add(14, -17.151300, 0.011388, 0.216215, 0.733286);
            ////table.Rows.Add(15, 0.739842, 0.004814, -0.995539, 0.068090);
            ////table.Rows.Add(16, 19.016500, 0.010905, 0.088328, -0.660656);
            ////table.Rows.Add(17, 36.332000, 0.026502, 0.626850, -0.513515);
            ////table.Rows.Add(18, 51.403600, 0.048156, 0.803937, -0.381583);
            ////table.Rows.Add(19, 63.124800, 0.072435, 0.880879, -0.292268);
            ////table.Rows.Add(20, 70.661100, 0.096199, 0.921889, -0.227326);
            ////table.Rows.Add(21, 73.521800, 0.116829, 0.946996, -0.175985);
            ////table.Rows.Add(22, 71.599400, 0.132384, 0.727516, -0.132456);


            table.Rows.Add(0, 1.000000, 1.000000, 1.000000, 0);
            table.Rows.Add(1, 0.352508, 0.986682, 0.999999, 0.001486);
            table.Rows.Add(2, -1.506810, 0.947552, 0.999981, 0.006013);
            table.Rows.Add(3, -4.335870, 0.885010, 0.99990, 0.013801);
            table.Rows.Add(4, -7.755310, 0.802853, 0.999667, 0.025248);
            table.Rows.Add(5, -11.282800, 0.705975, 0.999124, 0.040993);
            table.Rows.Add(6, -14.377500, 0.600000, 0.997998, 0.062021);
            table.Rows.Add(7, -16.490700, 0.490852, 0.995807, 0.089853);
            table.Rows.Add(8, -17.120100, 0.384328, 0.991661, 0.126879);
            table.Rows.Add(9, -15.860800, 0.285686, 0.983817, 0.176969);
            table.Rows.Add(10, -12.451300, 0.199292, 0.968606, 0.246600);
            table.Rows.Add(11, -6.808280, 0.128357, 0.937570, 0.346762);
            table.Rows.Add(12, 0.953091, 0.074774, 0.869300, 0.494251);
            table.Rows.Add(13, 10.514600, 0.039070, 0.708270, 0.693311);
            table.Rows.Add(14, 21.369400, 0.020470, 0.377256, 0.768280);
            table.Rows.Add(15, 32.853500, 0.017064, 0.197500, 0.225004);
            table.Rows.Add(16, 44.193500, 0.026055, 0.457373, -0.290476);
            table.Rows.Add(17, 54.567200, 0.044061, 0.681734, -0.398477);
            table.Rows.Add(18, 63.170900, 0.067441, 0.802192, -0.375830);
            table.Rows.Add(19, 69.289800, 0.092622, 0.868980, -0.328109);
            table.Rows.Add(20, 72.363100, 0.116387, 0.909747, -0.278620);
            table.Rows.Add(21,72.039000, 0.136112, 0.936924, -0.231445);
            table.Rows.Add(22, 68.213000, 0.149923, 0.956339, -0.186405);


            ResultDataGridView.DataSource = table;
        }

        public System.Data.DataTable Table 
        { 
            get 
            { 
                return ((System.Data.DataTable)ResultDataGridView.DataSource); } }

    }
}
