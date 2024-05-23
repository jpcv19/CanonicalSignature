using System.Text.Json.Serialization;

namespace Davivienda.Framework.Services.CanonicalSignature
{
    public class ErrorDetail
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}
