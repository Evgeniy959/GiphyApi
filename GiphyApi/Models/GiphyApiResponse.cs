using System.Collections.Generic;

namespace GiphyApi.Models
{
    public class GiphyApiResponse
    {
        public IEnumerable<Data> data { get; set; }
        public Pagination pagination { get; set; }
        public Meta meta { get; set; }
    }

}
