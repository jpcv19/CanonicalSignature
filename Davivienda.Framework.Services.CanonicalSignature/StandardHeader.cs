using System;
using System.Text.Json.Serialization;

namespace Davivienda.Framework.Services.CanonicalSignature
{
    public class StandardHeader
    {
        [JsonPropertyName("x-TransactionId")]
        public string? TransactionId { get; set; }
        [JsonPropertyName("x-SessionId")]
        public string? SessionId { get; set; }
        [JsonPropertyName("x-ChannelId")]
        public int ChannelId { get; set; }
        [JsonPropertyName("x-I18n")]
        public string? I18n { get; set; }
    }
}
