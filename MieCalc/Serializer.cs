using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

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
            
            // Сериализация
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.All;

            using (StreamWriter sw = new StreamWriter(@"c:\Users\Елена\Documents\VKR\MainForm\Paper\MieCalc\json.txt", true, System.Text.Encoding.Default))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static InitialData Deserialize(InitialData data, string filename)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.All;

            using (StreamReader sw = new StreamReader(@"c:\Users\Елена\Documents\VKR\MainForm\Paper\MieCalc\json.txt"))
            using (JsonReader reader = new JsonTextReader(sw))
            {
                data = (InitialData)serializer.Deserialize(reader);
            }
     
            return new InitialData();
        }
    }
}
