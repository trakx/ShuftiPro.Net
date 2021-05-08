using System;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Contracts;

namespace ShuftiPro.Tests
{
    public class ShuftiProBackgroundCheckServiceTests : ShuftiProTestBase
    {
        [TestCase("Maria", "Michaela", 1985, 09, 08)]
        [TestCase("Donald", "Trump", 1946, 06, 14)]
        public async Task Verify_ValidVerification_ReturnsFeedback(string firstName, string lastName, int year, int month, int day)
        {
            var verification = new ShuftiProVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Reference,
                BackgroundCheck = new ShuftiProBackgroundCheck
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

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeEmpty();
            feedback.Data.Should().NotBeNull();
            feedback.Data.BackgroundCheck.Should().NotBeNull();


            var status = await this.ShuftiPro.GetStatusAsync(new ShuftiProReference { Reference = verification.Reference });
            status.Should().NotBeNull();
            status.Reference.Should().BeEquivalentTo(verification.Reference);
            status.Data.Should().NotBeNull();
            status.Data.BackgroundCheck.Should().NotBeNull();
            status.Data.BackgroundCheck.AmlData.Should().NotBeNull();
        }
    }
}
