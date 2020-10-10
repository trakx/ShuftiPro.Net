using System;
using System.Net.Http;
using ShuftiPro.Contracts;
using ShuftiPro.Services;

namespace ShuftiPro
{
    public class ShuftiPro : IShuftiPro
    {
        private readonly HttpClient _httpClient;

        public ShuftiPro(Uri baseUri = null)
        {
            _httpClient = new HttpClient { BaseAddress = baseUri ?? new Uri("https://api.shuftipro.com") };
        }

        public ShuftiProFeedback VerifyAsync(ShuftiProVerification verification, ShuftiProCredentials credentials)
        {
            throw new NotImplementedException();
        }

        public ShuftiProStatus GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials credentials)
        {
            throw new NotImplementedException();
        }
    }
}
