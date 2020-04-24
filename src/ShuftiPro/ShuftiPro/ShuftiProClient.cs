using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShuftiPro.Exceptions;
using ShuftiPro.OnSite;

namespace ShuftiPro
{
    public class ShuftiProClient : IShuftiProClient
    {
        private readonly string hostUrl = "https://api.shuftipro.com";
        private readonly HttpClient httpClient;
        private readonly ShuftiProClientOptions clientOptions;

        public ShuftiProClient(HttpClient httpClient, ShuftiProClientOptions clientOptions)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            this.clientOptions = clientOptions ?? throw new ArgumentNullException(nameof(clientOptions));

            this.httpClient.BaseAddress = new Uri(hostUrl);
            this.SetBasicAuthorization();
        }

        private void EnsureValidRequest(object request)
        {
            var context = new ValidationContext(request);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(request, context, results))
            {
                throw new ShuftiProException(results.First().ErrorMessage);
            }
        }

        private void SetBasicAuthorization()
        {
            var parameter = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{this.clientOptions.ClientId}:{this.clientOptions.SecretKey}"));
            var authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), parameter);
            this.httpClient.DefaultRequestHeaders.Authorization = authorization;
        }

        public async Task<ShuftiProOnSiteFeedback> OnSiteDocumentVerificationAsync(ShuftiProOnSiteDocumentVerification verification)
        {
            this.EnsureValidRequest(verification);

            var rawRequest = JsonConvert.SerializeObject(verification);
            var response = await this.httpClient.PostAsync("", new StringContent(rawRequest, System.Text.Encoding.UTF8, "application/json"));
            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ShuftiProOnSiteFeedback>(responseContent);
        }
    }
}
