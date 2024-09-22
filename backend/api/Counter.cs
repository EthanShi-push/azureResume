using Newtonsoft.Json;

namespace Company.Function
{
    public class Counter
    {
        [JsonProperty("id")]
        public string id { get; set; }
        
        [JsonProperty("count")]
        public int count { get; set; }


    }

}