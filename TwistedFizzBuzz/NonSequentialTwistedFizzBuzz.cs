using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzz
{
    public class NonSequentialTwistedFizzBuzz
    {
        public static List<string> NonSequential(int[] values, Dictionary<int, string> tokens)
        {
            
            var result = new List<string>();

            foreach (var num in values)
            {
                var output = "";
                foreach (var token in tokens)
                {
                    if (num % token.Key == 0)
                        output += token.Value;
                }
                result.Add(string.IsNullOrEmpty(output) ? num.ToString() : output);
            }

            return result;
        }
    }
}
