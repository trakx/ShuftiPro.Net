using System;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using ShuftiPro.Contracts;
using ShuftiPro.Enums;

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

        [Test]
        public void SerializeStatus_ValidObject_BeSerialized()
        {
            var status = new ShuftiProStatus
            {
                Reference = "reference",
                Event = ShuftiProEvent.RequestDeleted,
                Data = null
            };

            var statusJson = JsonConvert.SerializeObject(status);
            statusJson.Should().NotBeEmpty();

            status = JsonConvert.DeserializeObject<ShuftiProStatus>(statusJson);
            status.Should().NotBeNull();
        }
    }
}
