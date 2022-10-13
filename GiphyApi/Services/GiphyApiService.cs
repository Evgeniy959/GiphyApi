using GiphyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GiphyApi.Services
{
    public class GiphyApiService
    {
        public string BaseUrl { get; }
        public string ApiKey { get; }
        private HttpClient httpClient;

        public GiphyApiService()
        {
            BaseUrl = "https://api.giphy.com/v1/gifs/search";
            ApiKey = "01riibfAzoW0vJwE5crOV45rAm6NAzcJ";
            httpClient = new HttpClient();

            /*BaseUrl = options.Value.BaseUrl;
            ApiKey = options.Value.ApiKey;
            httpClient = httpClientFactory.CreateClient();
            this.memoryCache = memoryCache;*/
        }
        public async Task<GiphyApiResponse> SearchByTitle(string title, int page)
        {
            var response = await httpClient.GetAsync($"{BaseUrl}?apikey={ApiKey}&q={title}&limit=25&offset=0&rating=g&lang=en&page={page}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<GiphyApiResponse>(json);

            return result;
        }
    }
    
}
//https://api.giphy.com/v1/gifs/translate?api_key=01riibfAzoW0vJwE5crOV45rAm6NAzcJ&s=%D0%BB%D0%B5%D0%B2
//https://api.giphy.com/v1/gifs/search?api_key=01riibfAzoW0vJwE5crOV45rAm6NAzcJ&q=%D0%BB%D0%B5%D0%B2&limit=25&offset=0&rating=g&lang=en
