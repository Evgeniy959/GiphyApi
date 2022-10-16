using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GiphyApi.Models
{
    public class GiphyApiResponse
    {
        [JsonPropertyName("data")]
        public IEnumerable<Data> dataArr { get; set; }
        public Pagination pagination { get; set; }
        /*[JsonPropertyName("meta")]
        public Meta metaArr { get; set; }*/
        public Data data { get; set; }
        public Meta meta { get; set; }
    }

}
