using System;
using System.IO;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using ShuftiPro.Enums;
using ShuftiPro.Services;

namespace ShuftiPro.Tests
{
    public class ShuftiProDocumentServiceTests
    {
        private ShuftiProCredentials credentials;
        private IShuftiProDocumentService service;
        private const string CallbackUrl = "https://webhook.site/3870c049-55f9-422e-8f73-deaa5efa50b3";

        [SetUp]
        public void Setup()
        {
            this.credentials = new ShuftiProCredentials
            {
                ClientId = TestConfiguration.Configuration.GetValue<string>("ClientId"),
                SecretKey = TestConfiguration.Configuration.GetValue<string>("SecretKey")
            };
            this.service = new ShuftiProClient(credentials).DocumentService;
        }

        [Test]
        public async Task VerifyOnSite_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProOnSiteDocumentVerification
            {
                Reference = Guid.NewGuid().ToString("N"),
                CallbackUrl = CallbackUrl,
                Document = new ShuftiProOnSiteDocument
                {
                    SupportedTypes = new[]
                    {
                        ShuftiProDocumentType.IdCard,
                        ShuftiProDocumentType.CreditOrDebitCard,
                        ShuftiProDocumentType.DrivingLicense,
                        ShuftiProDocumentType.Passport
                    }
                }
            };

            var feedback = await this.service.VerifyOnSiteAsync(verification);
            feedback.Should().NotBeNull();
            feedback.VerificationUrl.Should().NotBeEmpty();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        }

        [Test]
        public async Task VerifyOffSite_ValidVerification_ReturnsFeedback()
        {
            var image = await File.ReadAllBytesAsync("images/REAL_ID.png");
            var base64Image = Convert.ToBase64String(image);

            var verification = new ShuftiProOffSiteDocumentVerification
            {
                Reference = Guid.NewGuid().ToString("N"),
                CallbackUrl = CallbackUrl,
                Document = new ShuftiProOffSiteDocument
                {
                    SupportedTypes = new[]
                    {
                        ShuftiProDocumentType.IdCard,
                        ShuftiProDocumentType.CreditOrDebitCard,
                        ShuftiProDocumentType.DrivingLicense,
                        ShuftiProDocumentType.Passport
                    },
                    Proof = $"data:image/png;base64,{base64Image}"
                }
            };

            var feedback = await this.service.VerifyOffSiteAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        }
    }
}
