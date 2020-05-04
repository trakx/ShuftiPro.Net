using System;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using ShuftiPro.Enums;
using ShuftiPro.Services;

namespace ShuftiPro.Tests
{

    public class ShuftiProModelTests
    {
        [Test]
        public void SerializeName_EmptyValues_ReturnsEmptyString()
        {
            var name = new ShuftiProName();

            var result = JsonConvert.SerializeObject(name);
            result.Should().NotBeEmpty().And.BeEquivalentTo("{}");
        }

        [Test]
        public void SerializeDocument_EmptyValues_ThrowsSerializationException()
        {
            var document = new ShuftiProDocument();

            Action act = () => JsonConvert.SerializeObject(document);

            act.Should().Throw<JsonSerializationException>();
        }

        [Test]
        public void SerializeDocument_ValidValues_BeSerialized()
        {
            var document = new ShuftiProDocument { SupportedTypes = new[] { ShuftiProDocumentType.IdCard } };
            var result = JsonConvert.SerializeObject(document);

            result.Should().NotBeEmpty().And.BeEquivalentTo(@"{""supported_types"":[""id_card""]}");
        }
    }
}
