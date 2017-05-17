using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieCalc
{
    /// <summary>
    /// 
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public static void Serialize(InitialData data, string filename)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static InitialData Deserialize(string filename)
        {
            return new InitialData();
        }
    }
}
