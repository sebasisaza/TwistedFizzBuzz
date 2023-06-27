using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzz
{
    public class RangeTwistedFizzBuzz
    {
        public static List<string> Range(int[] values, Dictionary<int, string> tokens)
        {

            int start = values[0];
            int end = values[1];

            var result = new List<string>();
            for (int i = start; i <= end; i++)
            {
                var output = "";
                foreach (var token in tokens)
                {
                    if (i % token.Key == 0)
                        output += token.Value;
                }
                result.Add(string.IsNullOrEmpty(output) ? i.ToString() : output);
            }

            return result;
        }
    }
}
