using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace MieCalc
{
    /// <summary>
    /// 
    /// </summary>
    public class InitialData
    {
        public double WaveLength { get; set; }
        
        public double RangeMax { get; set; }

        public double RangeMin { get; set; }
        
        public int Steps { get; set; }
        
        public int DiscretsCount { get; set; }
        
        public double RelativeHumidity { get; set; }

        public InitialData()
        {
            WaveLength = 10.0;
            RangeMax = 100.0;
            RangeMin = 10.0;
            Steps = 20;
            DiscretsCount = 5;
            RelativeHumidity = 1.0;
        }


    }
}
