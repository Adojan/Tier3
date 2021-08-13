using System.Text.Json.Serialization;

namespace TierThree.Networking
{
    public class NetworkRequest
    {
        [JsonPropertyName("type")]
        public string NetworkType { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}