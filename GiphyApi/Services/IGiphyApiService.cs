using GiphyApi.Models;
using System.Threading.Tasks;

namespace GiphyApi.Services
{
    public interface IGiphyApiService
    {
        string ApiKey { get; }
        string BaseUrl { get; }

        Task<GiphyApiDetails> SearchById(string id);
        Task<GiphyApiResponse> SearchByTitle(string title, int page);
    }
}