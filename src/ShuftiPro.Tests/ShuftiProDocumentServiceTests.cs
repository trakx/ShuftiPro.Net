using System;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Contracts;
using ShuftiPro.Enums;

namespace ShuftiPro.Tests
{
    public class ShuftiProDocumentServiceTests : ShuftiProTestBase
    {
        [Test]
        public async Task VerifyOnSite_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProVerification
            {
                Reference = Guid.NewGuid().ToString("N"),
                CallbackUrl = CallbackUrl,
                Document = new ShuftiProDocument
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

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.VerificationUrl.Should().NotBeEmpty();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        }

        [Test]
        public async Task VerifyOffSite_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProVerification
            {
                Reference = Guid.NewGuid().ToString("N"),
                CallbackUrl = CallbackUrl,
                Document = new ShuftiProDocument
                {
                    SupportedTypes = new[]
                    {
                        ShuftiProDocumentType.IdCard,
                        ShuftiProDocumentType.CreditOrDebitCard,
                        ShuftiProDocumentType.DrivingLicense,
                        ShuftiProDocumentType.Passport
                    },
                    Proof = await this.GetBase64Image(TestConstants.Images.RealId)
                }
            };

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
            feedback.Data.Should().NotBeNull();
            feedback.Result.Should().NotBeNull();
        }
    }
}
