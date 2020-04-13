using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FileParser {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) {
            for(int i = 0; i < data.Count; i++)
            {
                for(int j = 0; j < data[i].Count; j++)
                {
                    data[i][j] = data[i][j].Trim(' ');
                }
            }
            return data; //-- return result here
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {
            string r = "\"test\"";


            for(int i = 0; i < data.Count; i++)
            {
                for(int j = 0; j < data[i].Count; j++)
                {
                    if (data[i][j].StartsWith("\"")){
                        data[i][j] = data[i][j].TrimStart('"');
                    }
                }
            }
            return data; //-- return result here
        }
    }
}