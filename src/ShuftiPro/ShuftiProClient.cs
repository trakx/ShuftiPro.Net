using System;
using System.Net.Http;
using System.Threading.Tasks;
using ShuftiPro.Services;

namespace ShuftiPro
{
    public class ShuftiProClient : IShuftiProClient
    {
        private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("https://api.shuftipro.com") };
        private readonly ShuftiProStatusService statusService;
        private readonly ShuftiProOnSiteService onSiteService;

        public ShuftiProClient()
        {
            this.AddressService = new ShuftiProAddressService(HttpClient);
            this.DocumentService = new ShuftiProDocumentService(HttpClient);
            this.FaceService = new ShuftiProFaceService(HttpClient);
            this.BackgroundCheckService = new ShuftiProBackgroundCheckService(HttpClient);
            this.statusService = new ShuftiProStatusService(HttpClient);
            this.onSiteService = new ShuftiProOnSiteService(HttpClient);
        }

        public ShuftiProClient(ShuftiProCredentials credentials)
        {
            this.AddressService = new ShuftiProAddressService(HttpClient, credentials);
            this.DocumentService = new ShuftiProDocumentService(HttpClient, credentials);
            this.FaceService = new ShuftiProFaceService(HttpClient, credentials);
            this.BackgroundCheckService = new ShuftiProBackgroundCheckService(HttpClient, credentials);
            this.statusService = new ShuftiProStatusService(HttpClient, credentials);
            this.onSiteService = new ShuftiProOnSiteService(HttpClient, credentials);
        }

        public IShuftiProAddressService AddressService { get; }

        public IShuftiProDocumentService DocumentService { get; }

        public IShuftiProBackgroundCheckService BackgroundCheckService { get; }

        public IShuftiProFaceService FaceService { get; }

        public Task<ShuftiProStatus> GetStatusAsync(ShuftiProReference reference, ShuftiProCredentials credentials = null) => this.statusService.GetStatusAsync(reference, credentials);

        public Task<ShuftiProOnSiteFeedback> VerifyOnSiteAsync(ShuftiProOnSiteVerification verification, ShuftiProCredentials credentials = null) => this.onSiteService.VerifyOnSiteAsync(verification, credentials);
    }
}
