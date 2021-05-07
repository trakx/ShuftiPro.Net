using System;
using System.IO;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Enums;
using ShuftiPro.Services;
using ShuftiPro.Services.Document;

namespace ShuftiPro.Tests
{
    public class ShuftiProDocumentServiceTests : ShuftiProServiceTestBase
    {
        private IShuftiProDocumentService documentService;

        public override void Setup()
        {
            base.Setup();
            this.documentService = new ShuftiProClient(Credentials).DocumentService;
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
                    },
                    FetchEnhancedData = true
                }
            };

            var feedback = await this.documentService.VerifyOnSiteAsync(verification);
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

            var feedback = await this.documentService.VerifyOffSiteAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
            feedback.Data.Should().NotBeNull();
            feedback.Result.Should().NotBeNull();
        }
    }
}
