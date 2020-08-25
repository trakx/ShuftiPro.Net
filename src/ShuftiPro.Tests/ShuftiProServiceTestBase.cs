using System;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace ShuftiPro.Tests
{
    public abstract class ShuftiProServiceTestBase
    {
        protected ShuftiProCredentials Credentials;
        protected const string CallbackUrl = "https://webhook.site/c3f7605b-587c-4e1b-98f2-119bba6b7df0";

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
