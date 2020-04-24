using System;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using ShuftiPro.Base;
using ShuftiPro.Enums;
using ShuftiPro.Exceptions;
using ShuftiPro.OnSite;

namespace ShuftiPro.Tests
{
    public class Tests
    {
        private string clientId;
        private string secretKey;
        private HttpClient httpClient;
        private ShuftiProClientOptions options;
        private IShuftiProClient shuftiProClient;

        [SetUp]
        public void Setup()
        {
            this.httpClient = new HttpClient();
            this.options = new ShuftiProClientOptions
            {
                ClientId = TestConfiguration.Configuration.GetValue<string>("ClientId"),
                SecretKey = TestConfiguration.Configuration.GetValue<string>("SecretKey")
            };
            this.shuftiProClient = new ShuftiProClient(this.httpClient, this.options);
        }

        [Test]
        public void Initialization_NullArguments_ThrowsException()
        {
            FluentActions.Invoking(() => new ShuftiProClient(null, null))
                .Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Initialization_NullOptionArgument_ThrowsException()
        {
            FluentActions.Invoking(() => new ShuftiProClient(new HttpClient(), null))
                .Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Initialization_ValidArguments_ShouldBeInitialized()
        {
            var client = new ShuftiProClient(new HttpClient(), new ShuftiProClientOptions());
            client.Should().NotBeNull();
        }

        [Test]
        public void Initialization_ValidArguments_ShouldSetAuthorizationHeader()
        {
            //Init

            var options = new ShuftiProClientOptions { ClientId = "clientId", SecretKey = "secretId" };

            //Act
            var client = new ShuftiProClient(httpClient, options);

            //Assert
            client.Should().NotBeNull();
            httpClient.DefaultRequestHeaders.Authorization.Should().NotBeNull();
            httpClient.DefaultRequestHeaders.Authorization.Scheme.Should().NotBeEmpty();
            httpClient.DefaultRequestHeaders.Authorization.Parameter.Should().NotBeEmpty();
        }

        [Test]
        public void DocumentVerification_InvalidVerification_ThrowsException()
        {
            var verification = new ShuftiProOnSiteDocumentVerification();

            Func<Task<ShuftiProOnSiteFeedback>> act = async () => await this.shuftiProClient.OnSiteDocumentVerificationAsync(verification);
            act.Should().Throw<ShuftiProException>();
        }

        [Test]
        public async Task DocumentVerification_ValidVerification_ReturnsFeedback()
        {
            var document = new ShuftiProOnSiteDocument { SupportedTypes = new[] { DocumentType.IdCard, DocumentType.CreditOrDebitCard, DocumentType.DrivingLicense, DocumentType.Passport } };
            var verification = new ShuftiProOnSiteDocumentVerification
            {
                Reference = Guid.NewGuid().ToString("N"),
                CallbackUrl = "https://fake.com/api",
                Document = document
            };

            var feedback = await this.shuftiProClient.OnSiteDocumentVerificationAsync(verification);
            feedback.Should().NotBeNull();
            feedback.VerificationUrl.Should().NotBeEmpty();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        }
    }
}