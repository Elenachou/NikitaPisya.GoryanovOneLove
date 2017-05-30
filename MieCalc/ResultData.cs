using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace MieCalc
{
    public class ResultData
    {
        public double DiffractionParameter;
        public Complex[] S1, S2;
        public double QEXT, QSCA, QABS, Lambda, CSCA, CEXT, CABS;
        public String[] OptI, SCA, EXT, ABS;
        public ResultData()
        {
            S1 = new Complex[200];
            S2 = new Complex[200];
            OptI = new string[4];
            SCA = new string[4];
            EXT = new string[4];
            ABS = new string[4];
        }
    }
}
