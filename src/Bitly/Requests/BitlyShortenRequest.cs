using System;
using System.Net.Http;

namespace Bitly.Requests
{
    public class BitlyShortenRequest
    {
        public string LongUrl { get; set; }
        public BitlyShortDomain? Domain { get; set; }
        public BitlyFormat? Format { get; set; }
    }
}