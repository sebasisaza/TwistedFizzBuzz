using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzz
    {

        public static async void FizzBuzz(int[] values, Dictionary<int, string> tokens, bool sequential = false, bool callApi = false) 
        {
            if (callApi) {
                var tokensApi = await GetApiToken.GetToken();   
                tokens = tokens.Concat(tokensApi).GroupBy(d => d.Key).ToDictionary(d => d.Key, d => d.First().Value);
            }

            if (sequential)
            {
                var res = RangeTwistedFizzBuzz.Range(values, tokens);
                PrintTwistedFizzBuzz.Print(res);
            }

            if (!sequential)
            {
                var res = NonSequentialTwistedFizzBuzz.NonSequential(values, tokens);
                PrintTwistedFizzBuzz.Print(res);
            }

        }
        

    }

        


}