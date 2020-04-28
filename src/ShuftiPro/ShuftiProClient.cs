using System;
using System.Net.Http;
using ShuftiPro.Services;

namespace ShuftiPro
{
    public class ShuftiProClient : IShuftiProClient
    {
        private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("https://api.shuftipro.com") };

        public ShuftiProClient()
        {
            this.AddressService = new ShuftiProAddressService(HttpClient);
            this.DocumentService = new ShuftiProDocumentService(HttpClient);
        }

        public ShuftiProClient(ShuftiProCredentials credentials)
        {
            this.AddressService = new ShuftiProAddressService(HttpClient, credentials);
            this.DocumentService = new ShuftiProDocumentService(HttpClient, credentials);
        }

        public IShuftiProAddressService AddressService { get; }
        public IShuftiProDocumentService DocumentService { get; }
    }
}
