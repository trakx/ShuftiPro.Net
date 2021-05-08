using System.IO;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NUnit.Framework;
using ShuftiPro.Contracts;
using ShuftiPro.Exceptions;
using ShuftiPro.Options;

namespace ShuftiPro.Tests
{
    public class ShuftiProGeneralTests : ShuftiProTestBase
    {
        private ShuftiProCredentials credentials;
        private ShuftiPro shuftiPro;

        private const string EmptyCredentialsMessage = "Empty credentials not allowed";

        [SetUp]
        public void SetUp()
        {
            this.credentials = new ShuftiProCredentials
            {
                ClientId = TestConfiguration.Configuration.GetValue<string>("ClientId"),
                SecretKey = TestConfiguration.Configuration.GetValue<string>("SecretKey")
            };

            this.shuftiPro = new ShuftiPro(credentials);
        }

        [Test]
        public void Initialization_NullCredentials_ThrowsException()
        {
            FluentActions.Invoking(() => new ShuftiPro(null as ShuftiProCredentials))
                .Should().Throw<ShuftiProException>().Which.Message.Should().Be(EmptyCredentialsMessage);
        }

        [Test]
        public void Initialization_EmptyCredentials_ThrowsException()
        {
            FluentActions.Invoking(() => new ShuftiPro(new ShuftiProCredentials()))
                .Should().Throw<ShuftiProException>().Which.Message.Should().Be(EmptyCredentialsMessage);
        }

        [Test]
        public void Initialization_ValidArguments_ShouldBeInitialized()
        {
            var client = new ShuftiPro(this.credentials);
            client.Should().NotBeNull();
        }

        [Test]
        public async Task DeserializeFeedback_ValidJson_BeDeserialized()
        {
            var json = await File.ReadAllTextAsync("jsons/verification_response.json");
            var feedback = JsonConvert.DeserializeObject<ShuftiProFeedback>(json);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeEmpty();
            feedback.Data.Should().NotBeNull();
            feedback.Data.Address.Should().NotBeNull();
            feedback.Data.Document.Should().NotBeNull();
            feedback.Data.Consent.Should().NotBeNull();
            feedback.Result.Should().NotBeNull();
            feedback.Info.Should().NotBeNull();
            feedback.Info.Agent.Should().NotBeNull();
            feedback.Info.Geolocation.Should().NotBeNull();
        }

        [Test]
        public async Task DeserializeStatus_ValidJson_BeDeserialized()
        {
            var json = await File.ReadAllTextAsync("jsons/status_with_additional_data.json");
            var status = JsonConvert.DeserializeObject<ShuftiProStatus>(json);
            status.Should().NotBeNull();
            status.Reference.Should().NotBeEmpty();
            status.Proofs.Should().NotBeNull();
            status.Proofs.Document.Should().NotBeNull();
            status.AdditionalData.Should().NotBeNull();
            status.AdditionalData.Document.Should().NotBeNull();
            status.AdditionalData.Document.Proof.Should().NotBeEmpty();
        }
    }
}
