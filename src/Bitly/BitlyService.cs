using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Bitly.Requests;
using Bitly.Responses;
using Newtonsoft.Json;

namespace Bitly
{
    public class BitlyService
    {
        private const string APIUrl = "https://api-ssl.bitly.com/v3/";
        HttpClient client = new HttpClient();
        private string _accessToken;

        /// <summary>
        /// Initialize the BitlyService with an access token
        /// Create your token at https://bitly.com/a/oauth_apps
        /// for more information http://dev.bitly.com/authentication.html
        /// </summary>
        /// <param name="accessToken"></param>
        public BitlyService(string accessToken)
        {
            _accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// //Given a long URL, returns a Bitlink.
        /// </summary>
        /// <param name="longUrl"></param>
        public async Task<BitlyShortenResponse> Shorten(string longUrl)
        {
            return await Shorten(new BitlyShortenRequest { LongUrl = longUrl });
        }

        /// <summary>
        /// //Given a long URL, returns a Bitlink.
        /// </summary>
        /// <param name="shortenRequest">An instance of BitlyShortenRequest.</param>
        public async Task<BitlyShortenResponse> Shorten(BitlyShortenRequest shortenRequest)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("access_token", _accessToken);
            parameters.Add("longUrl", System.
            Net.WebUtility.UrlEncode(shortenRequest.LongUrl));

            if (shortenRequest.Domain.HasValue) parameters.Add("longUrl", shortenRequest.Domain.Value.ToString().Replace("_", "."));
            if (shortenRequest.Domain.HasValue) parameters.Add("format", shortenRequest.Format.Value.ToString());

            var query = parameters.Select(o => $"{o.Key}={o.Value}").Aggregate((a, b) => a + "&" + b);

            var response = await client.GetAsync($"{APIUrl}/shorten?{query}");

            var responseBody = await response.Content.ReadAsStringAsync();

            var bitlyResponse = JsonConvert.DeserializeObject<BitlyResponse>(responseBody);

            if (bitlyResponse.StatusCode == 200)
            {
                return JsonConvert.DeserializeObject<BitlyShortenResponse>(responseBody);
            }

            return new BitlyShortenResponse { Status = bitlyResponse.Status, StatusCode = bitlyResponse.StatusCode };
        }
    }
}
