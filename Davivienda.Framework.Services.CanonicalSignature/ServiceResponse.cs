
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Davivienda.Framework.Services.CanonicalSignature
{
    public class ServiceResponse<T> where T : class
    {
        public ServiceResponse() { }

        [JsonPropertyName("data")]
        public T? Data { get; set; }
        [JsonPropertyName("succeeded")]
        public bool Succeeded { get; set; }
        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }
        [JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }
        [JsonPropertyName("errors")]
        public List<ErrorDetail>? Errors { get; set; }
    }
}
