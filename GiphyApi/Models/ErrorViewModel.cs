using System;

namespace GiphyApi.Models
{
    public partial class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);


    }
}
