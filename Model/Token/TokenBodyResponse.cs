﻿
using Newtonsoft.Json;


namespace ApiTests.Model.Token
{
    public class TokenBodyResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }
    }
  

}

