using System;
using System.Reflection;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Services;

namespace ShuftiPro.Tests
{
    public class ShuftiProBackgroundCheckServiceTests : ShuftiProServiceTestBase
    {
        private IShuftiProBackgroundCheckService backgroundService;

        public override void Setup()
        {
            base.Setup();
            this.backgroundService = new ShuftiProClient(Credentials).BackgroundCheckService;
        }

        [TestCase("Maria", "Michaela", 1985, 09, 08)]
        [TestCase("Donald", "Trump", 1946, 06, 14)]
        public async Task Verify_ValidVerification_ReturnsFeedback(string firstName, string lastName, int year, int month, int day)
        {
            var verification = new ShuftiProBackgroundCheckVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Reference,
                Check = new ShuftiProBackgroundCheck
                {
                    Name = new ShuftiProName
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        FuzzyMatch = true
                    },
                    DayOfBirth = new DateTime(year, month, day)
                }
            };

            var feedback = await this.backgroundService.VerifyAsync(verification);
            feedback.Should().NotBeNull();
        }
    }
}
