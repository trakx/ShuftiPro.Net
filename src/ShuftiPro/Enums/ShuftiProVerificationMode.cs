using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProVerificationMode
    {
        [EnumMember(Value = "any")]
        Any = 1,

        [EnumMember(Value = "image_only")]
        ImageOnly = 2,

        [EnumMember(Value = "video_only")]
        VideoOnly = 3
    }
}
