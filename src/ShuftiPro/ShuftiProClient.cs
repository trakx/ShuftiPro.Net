using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShuftiPro.Exceptions;
using ShuftiPro.OnSite;

namespace ShuftiPro
{
    public class ShuftiProClient : IShuftiProClient
    {
        private readonly ShuftiProCredentials _credentials;
        private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("https://api.shuftipro.com") };

        public ShuftiProClient()
        {
        }

        public ShuftiProClient(ShuftiProCredentials credentials)
        {
            EnsureCredentialsIsValid(credentials);
            _credentials = credentials;
        }

        public Task<ShuftiProOnSiteFeedback> VerifyDocumentOnSiteAsync(ShuftiProOnSiteDocumentVerification verification, ShuftiProCredentials credentials = null)
        {
            EnsureRequestIsValid(verification);

            return MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }

        public Task<ShuftiProOnSiteFeedback> VerifyAddressOnSiteAsync(ShuftiProOnSiteAddressVerification verification, ShuftiProCredentials credentials = null)
        {
            EnsureRequestIsValid(verification);

            return MakeCall<ShuftiProOnSiteFeedback>(HttpMethod.Post, null, verification, credentials);
        }

        private async Task<TResponse> MakeCall<TResponse>(HttpMethod method, Uri requestUri, object content, ShuftiProCredentials credentials = null)
        {
            var httpRequest = new HttpRequestMessage(method, requestUri);
            httpRequest.Headers.Authorization = this.GetAuthorizationHeader(credentials ?? this._credentials);

            var requestContent = JsonConvert.SerializeObject(content);
            httpRequest.Content = new StringContent(requestContent, Encoding.UTF8, "application/json");

            try
            {
                var response = await HttpClient.SendAsync(httpRequest);
                var responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TResponse>(responseContent);
            }
            catch (Exception e)
            {
                throw new ShuftiProException(e.Message, e);
            }
        }

        private AuthenticationHeaderValue GetAuthorizationHeader(ShuftiProCredentials credentials)
        {
            this.EnsureCredentialsIsValid(credentials);
            var parameter = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{credentials.ClientId}:{credentials.SecretKey}"));
            var authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), parameter);
            return authorization;
        }

        private void EnsureRequestIsValid(object request)
        {
            var context = new ValidationContext(request);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(request, context, results))
            {
                throw new ValidationException(results.First().ErrorMessage);
            }
        }

        private void EnsureCredentialsIsValid(ShuftiProCredentials credentials)
        {
            if (credentials == null || string.IsNullOrEmpty(credentials.ClientId) || string.IsNullOrEmpty(credentials.SecretKey))
            {
                throw new InvalidCredentialException("Empty credentials not allowed");
            }
        }
    }
}
