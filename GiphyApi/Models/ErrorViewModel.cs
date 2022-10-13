using System;

namespace GiphyApi.Models
{
    public partial class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);


        public class Rootobject
        {
            public Datum[] data { get; set; }
            public Pagination pagination { get; set; }
            public Meta meta { get; set; }
        }

        public class Pagination
        {
            public int total_count { get; set; }
            public int count { get; set; }
            public int offset { get; set; }
        }

        public class Meta
        {
            public int status { get; set; }
            public string msg { get; set; }
            public string response_id { get; set; }
        }

        public class Datum
        {
            public string type { get; set; }
            public string id { get; set; }
            public string url { get; set; }
            public string slug { get; set; }
            public string bitly_gif_url { get; set; }
            public string bitly_url { get; set; }
            public string embed_url { get; set; }
            public string username { get; set; }
            public string source { get; set; }
            public string title { get; set; }
            public string rating { get; set; }
            public string content_url { get; set; }
            public string source_tld { get; set; }
            public string source_post_url { get; set; }
            public int is_sticker { get; set; }
            public string import_datetime { get; set; }
            public string trending_datetime { get; set; }
            public Images images { get; set; }
            public User user { get; set; }
            public string analytics_response_payload { get; set; }
            public Analytics analytics { get; set; }
        }


        public class User
        {
            public string avatar_url { get; set; }
            public string banner_image { get; set; }
            public string banner_url { get; set; }
            public string profile_url { get; set; }
            public string username { get; set; }
            public string display_name { get; set; }
            public string description { get; set; }
            public string instagram_url { get; set; }
            public string website_url { get; set; }
            public bool is_verified { get; set; }
        }


    }
}
