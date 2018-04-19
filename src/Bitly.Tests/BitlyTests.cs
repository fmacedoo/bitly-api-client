using System;
using System.Threading.Tasks;
using System.Linq;
using Xunit;

namespace Bitly.Tests
{
    public class BitlyTests
    {
        private readonly BitlyService _bitlyService;

        public BitlyTests()
        {
            _bitlyService = new BitlyService("21392ff1718d0277e0b2b43ea4bc491902755911");
        }

        [Fact]
        public async Task Shorten()
        {
            var longUrl = "http://google.com.br/";

            var result = await _bitlyService.Shorten(longUrl);

            Assert.Equal(200, result.StatusCode);
            Assert.Equal("OK", result.Status);
            Assert.Equal(longUrl, result?.Data?.LongUrl);
        }
    }
}
