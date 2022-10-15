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
            BaseUrl = "https://api.giphy.com/v1/gifs/";
            //ApiKey = "01riibfAzoW0vJwE5crOV45rAm6NAzcJ";
            ApiKey = "2cZh7c1R386eVz3BE2PBb2ARmJuVfTen";
            httpClient = new HttpClient();

            /*BaseUrl = options.Value.BaseUrl;
            ApiKey = options.Value.ApiKey;
            httpClient = httpClientFactory.CreateClient();
            this.memoryCache = memoryCache;*/
        }
        public async Task<GiphyApiResponse> SearchByTitle(string title, int page)
        {
            var response = await httpClient.GetAsync($"{BaseUrl}search?apikey={ApiKey}&q={title}&limit=24&offset={page}&rating=g&lang=en");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<GiphyApiResponse>(json);
            return result;
        }
        public async Task<DataId> SearchById(string id)
        {
            var response = await httpClient.GetAsync($"{BaseUrl}{id}?apikey={ApiKey}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DataId>(json);
            return result;
            //return json;
        }
    }
    
}
//https://api.giphy.com/v1/gifs/search?api_key=01riibfAzoW0vJwE5crOV45rAm6NAzcJ&q=%D0%BB%D0%B5%D0%B2&limit=25&offset=0&rating=g&lang=en
//https://api.giphy.com/v1/gifs/553vlRAc1XZTVlAk3L?api_key=01riibfAzoW0vJwE5crOV45rAm6NAzcJ
//https://api.giphy.com/v1/gifs/553vlRAc1XZTVlAk3L?api_key=01riibfAzoW0vJwE5crOV45rAm6NAzcJ