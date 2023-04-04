using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.Model.Token
{
    public class TokenPostBody
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        public TokenPostBody()
        {
            ClientId = "U4NIvBXXKILKrwBFM3IrKTR4iyZzKWfj";
            ClientSecret = "4Gl4QNxeVeRQnGk1j0COoHYQE2J4O3AshaKgNBFlc_DRNv4O2lvps6mXzynvimGE";
            GrantType = "client_credentials";
        }
  
    }

}





