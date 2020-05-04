using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Enums;
using ShuftiPro.Services;

namespace ShuftiPro.Tests
{
    public class ShuftiProAddressServiceTests : ShuftiProServiceTestBase
    {
        private IShuftiProAddressService addressService;

        public override void Setup()
        {
            base.Setup();
            this.addressService = new ShuftiProClient(Credentials).AddressService;
        }

        [Test]
        public async Task VerifyOnSite_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProOnSiteAddressVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Reference,
                Address = new ShuftiProOnSiteAddress
                {
                    SupportedTypes = new[]
                    {
                       ShuftiProAddressType.IdCard,
                       ShuftiProAddressType.BankStatement,
                       ShuftiProAddressType.DrivingLicense,
                       ShuftiProAddressType.EmployerLetter,
                       ShuftiProAddressType.InsuranceAgreement,
                       ShuftiProAddressType.Passport,
                       ShuftiProAddressType.RentAgreement,
                       ShuftiProAddressType.TaxBill,
                       ShuftiProAddressType.UtilityBill
                    }
                }
            };

            var feedback = await this.addressService.VerifyOnSiteAsync(verification);
            feedback.Should().NotBeNull();
        }
    }
}
