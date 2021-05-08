using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using ShuftiPro.Options;

namespace ShuftiPro.Tests
{
    public abstract class ShuftiProTestBase
    {
        protected ShuftiProCredentials Credentials;
        protected ShuftiPro ShuftiPro;
        protected const string CallbackUrl = "https://webhook.site/eb5b2826-3f36-4a17-b89a-7147dc1d6e15";

        [SetUp]
        public virtual void Setup()
        {
            this.Credentials = new ShuftiProCredentials
            {
                ClientId = TestConfiguration.Configuration.GetValue<string>("ClientId"),
                SecretKey = TestConfiguration.Configuration.GetValue<string>("SecretKey")
            };

            this.ShuftiPro = new ShuftiPro(Credentials);
        }

        protected async Task<string> GetBase64Image(string imageName)
        {
            var image = await File.ReadAllBytesAsync($"images/{imageName}");
            var base64Image = Convert.ToBase64String(image);

            return $"data:image/png;base64,{base64Image}";
        }

        protected string Reference => Guid.NewGuid().ToString("N");
    }
}
