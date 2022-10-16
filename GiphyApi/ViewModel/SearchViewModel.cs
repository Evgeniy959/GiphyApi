using GiphyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyApi.ViewModel
{
    public class SearchViewModel
    {
        public IEnumerable<Data> Data { get; set; }
        public string Title { get; set; }
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
