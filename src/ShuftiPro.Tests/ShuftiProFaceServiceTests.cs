using System;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Contracts;

namespace ShuftiPro.Tests
{
    public class ShuftiProFaceServiceTests : ShuftiProTestBase
    {
        [Test]
        public async Task VerifyOnSite_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Guid.NewGuid().ToString("N"),
                Face = new ShuftiProFace()
            };

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.VerificationUrl.Should().NotBeEmpty();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        }
    }
}
