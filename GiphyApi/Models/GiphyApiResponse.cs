﻿using System.Collections.Generic;

namespace GiphyApi.Models
{
    //public partial class ErrorViewModel
    //{
        public class GiphyApiResponse
        {
            public IEnumerable<DataId> data { get; set; }
            public Pagination pagination { get; set; }
            public Meta meta { get; set; }
        }


    //}
}
