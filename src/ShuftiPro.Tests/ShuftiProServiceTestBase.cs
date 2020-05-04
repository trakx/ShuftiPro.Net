using System;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace ShuftiPro.Tests
{
    public abstract class ShuftiProServiceTestBase
    {
        protected ShuftiProCredentials Credentials;
        protected const string CallbackUrl = "https://webhook.site/3870c049-55f9-422e-8f73-deaa5efa50b3";

        [SetUp]
        public virtual void Setup()
        {
            this.Credentials = new ShuftiProCredentials
            {
                ClientId = TestConfiguration.Configuration.GetValue<string>("ClientId"),
                SecretKey = TestConfiguration.Configuration.GetValue<string>("SecretKey")
            };
        }

        protected string Reference => Guid.NewGuid().ToString("N");
    }
}
