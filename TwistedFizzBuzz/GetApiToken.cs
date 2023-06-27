using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzz
{
    public class GetApiToken
    {
        public static async Task<Dictionary<int, string>> GetToken()
        {
            var client = new HttpClient();

            var response = client.GetAsync("https://rich-red-cocoon-veil.cyclic.app/random").Result;

            response.EnsureSuccessStatusCode();

            var content = response.Content.ReadAsStringAsync().Result;

            var token = JsonConvert.DeserializeObject<Token>(content);

            return new Dictionary<int, string> { { token.multiple, token.word } };
        }
    }
}
