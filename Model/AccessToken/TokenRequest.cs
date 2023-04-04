using Newtonsoft.Json;

namespace ApiTests.Model.AccessToken
{
    class TokenRequest
    {
        public TokenRequest(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            GrantType = "client_credentials";

        }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

    }
}
