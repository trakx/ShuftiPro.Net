using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using ShuftiPro.Enums;
using ShuftiPro.Options;
using ShuftiPro.Services;
using ShuftiPro.Services.Base;
using ShuftiPro.Services.Document;
using ShuftiPro.Services.Face;

namespace ShuftiPro.Tests
{
    public class ShuftiProClientTests : ShuftiProServiceTestBase
    {
        private ShuftiProCredentials options;
        private IShuftiProClient shuftiProClient;

        [SetUp]
        public void Setup()
        {
            this.options = new ShuftiProCredentials
            {
                ClientId = TestConfiguration.Configuration.GetValue<string>("ClientId"),
                SecretKey = TestConfiguration.Configuration.GetValue<string>("SecretKey")
            };
            this.shuftiProClient = new ShuftiProClient(this.options);
        }

        [Test]
        public void Initialization_NullCredentials_ThrowsException()
        {
            FluentActions.Invoking(() => new ShuftiProClient(null))
                .Should().Throw<InvalidCredentialException>();
        }

        [Test]
        public void Initialization_EmptyCredentials_ThrowsException()
        {
            FluentActions.Invoking(() => new ShuftiProClient(new ShuftiProCredentials()))
                .Should().Throw<InvalidCredentialException>();
        }

        [Test]
        public void Initialization_ValidArguments_ShouldBeInitialized()
        {
            var client = new ShuftiProClient(this.options);
            client.Should().NotBeNull();
        }

        [Test]
        public void DocumentVerification_InvalidVerification_ThrowsException()
        {
            var verification = new ShuftiProOnSiteDocumentVerification();

            Func<Task<ShuftiProOnSiteFeedback>> act = async () => await this.shuftiProClient.DocumentService.VerifyOnSiteAsync(verification);
            act.Should().Throw<ValidationException>();
        }

        [Test]
        public async Task GetStatus_ValidReference_ReturnsStatus()
        {
            var refer = "bAQAAAAAAABRPpIJcwEAAP1dWtWZ";
            var reference = new ShuftiProReference { Reference = refer };
            var status = await this.shuftiProClient.GetStatusAsync(reference);
            status.Should().NotBeNull();
            status.Reference.Should().NotBeNullOrEmpty().And.BeEquivalentTo(refer);
            status.Data.Should().NotBeNull();
            status.Result.Should().NotBeNull();
        }

        [Test]
        public async Task GetStatus_ReferenceWithProof_ReturnsStatus()
        {
            var refer = "180e1c042d724d538bfbf2c900fd7548";
            var reference = new ShuftiProReference { Reference = refer };
            var status = await this.shuftiProClient.GetStatusAsync(reference);
            status.Should().NotBeNull();
            status.Reference.Should().NotBeNullOrEmpty().And.BeEquivalentTo(refer);
            status.Proofs.Should().NotBeNull();
            status.Result.Should().NotBeNull();
        }

        [Test]
        public async Task GetStatus_ReferenceWithDocument_ReturnsStatus()
        {
            var refer = "ad10c3ffb9684bc18d01f33b760a9479";
            var reference = new ShuftiProReference { Reference = refer };
            var status = await this.shuftiProClient.GetStatusAsync(reference);
            status.Should().NotBeNull();
            status.Reference.Should().NotBeNullOrEmpty().And.BeEquivalentTo(refer);
            status.Proofs.Should().NotBeNull();
            status.Result.Should().NotBeNull();
            status.AdditionalData.Should().NotBeNull();
            status.AdditionalData.Document.Should().NotBeNull();
            status.AdditionalData.Document.Proof.Should().NotBeNull();
            status.AdditionalData.Document.ProofDict.Should().NotBeEmpty();
        }

        [Test]
        public async Task GetStatus_ReferenceWithAddress_ReturnsStatus()
        {
            var refer = "87dc8ca2744d4ad0ae3dc2094edaa1b4";
            var reference = new ShuftiProReference { Reference = refer };
            var status = await this.shuftiProClient.GetStatusAsync(reference);
            status.Should().NotBeNull();
            status.Reference.Should().NotBeNullOrEmpty().And.BeEquivalentTo(refer);
            status.Proofs.Should().NotBeNull();
            status.Result.Should().NotBeNull();
            status.Data.Should().NotBeNull();
            status.Data.Address.Should().NotBeNull();
        }

        [Test]
        public async Task VerifyOnSite_ValidRequest_ReturnsFeedback()
        {
            var verification = new ShuftiProOnSiteVerification
            {
                Reference = Reference,
                CallbackUrl = CallbackUrl,
                Face = new ShuftiProOnSiteFace
                {
                    AllowOffline = false,
                    AllowOnline = true
                },
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

            var feedback = await this.shuftiProClient.VerifyOnSiteAsync(verification);
            feedback.Should().NotBeNull();
            feedback.VerificationUrl.Should().NotBeEmpty();
            feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        }
    }
}