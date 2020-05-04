using System;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Services;

namespace ShuftiPro.Tests
{
    public class ShuftiProFaceServiceTests : ShuftiProServiceTestBase
    {
        private IShuftiProFaceService faceService;

        public override void Setup()
        {
            base.Setup();
            this.faceService = new ShuftiProClient(Credentials).FaceService;
        }

        [Test]
        public async Task VerifyOnSite_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProOnSiteFaceVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Guid.NewGuid().ToString("N"),
                Face = new ShuftiProOnSiteFace()
            };

            var feedback = await this.faceService.VerifyOnSiteAsync(verification);
            feedback.Should().NotBeNull();
            feedback.VerificationUrl.Should().NotBeEmpty();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        }
    }
}
