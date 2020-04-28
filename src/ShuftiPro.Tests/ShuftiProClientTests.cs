using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using ShuftiPro.Enums;
using ShuftiPro.OnSite;
using ShuftiPro.Services;

namespace ShuftiPro.Tests
{
    public class Tests
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
        

        //[Test]
        //public async Task AddressVerification_ValidVerification_ReturnsFeedback()
        //{
        //    var verification = new ShuftiProOnSiteAddressVerification()
        //    {
        //        Reference = Guid.NewGuid().ToString("N"),
        //        CallbackUrl = CallbackUrl,
        //        Address = new ShuftiProOnSiteAddress
        //        {
        //            SupportedTypes = new[] { ShuftiProAddressType.IdCard, ShuftiProAddressType.TaxBill, ShuftiProAddressType.DrivingLicense }
        //        }
        //    };

        //    var feedback = await this.shuftiProClient.VerifyAddressOnSiteAsync(verification);
        //    feedback.Should().NotBeNull();
        //    feedback.VerificationUrl.Should().NotBeEmpty();
        //    feedback.Reference.Should().NotBeEmpty().And.BeEquivalentTo(verification.Reference);
        //}
    }
}