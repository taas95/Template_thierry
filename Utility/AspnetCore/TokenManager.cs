using Newtonsoft.Json;

namespace Utility.AspnetCore
{
   [JsonObject("tokenManager")]
    public class TokenManager
    {
        [JsonProperty("secret")]
        public string Secret { get; set; }
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("audience")]
        public string Audience { get; set; }


        [JsonProperty("accessExpiration")]
        public int accessExpiration { get; set; }
      
        [JsonProperty("refreshExpiration")]
        public int RefreshExpiration { get; set; }
       
    }
}