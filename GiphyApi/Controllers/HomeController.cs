using GiphyApi.Models;
using GiphyApi.Services;
using GiphyApi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GiphyApiService giphyApiService;

        public HomeController(ILogger<HomeController> logger, GiphyApiService giphyApiService)
        {
            _logger = logger;
            this.giphyApiService = giphyApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(string giphyTitle, int page = 1)
        {
            var result = await giphyApiService.SearchByTitle(giphyTitle, page);
            
            SearchViewModel searchViewModel = new SearchViewModel()
            {
                CurrentPage = page,
                Title = giphyTitle,
                data = result.data,
                TotalPages = (int)Math.Ceiling(result.pagination.total_count / 24.0),
                TotalResults = result.pagination.total_count
            };
            return View(searchViewModel);
        }

        public async Task<IActionResult> UserInfo(string giphyTitle, int page = 1)
        {
            Data data = new Data();
            data.Title = giphyTitle;
            //User user = new User();
            var result = await giphyApiService.UserShow(giphyTitle, page);
            SearchViewModel searchViewModel = new SearchViewModel()
            {
                CurrentPage = page,
                Title = giphyTitle,
                data = result.data,
                TotalPages = (int)Math.Ceiling(result.pagination.total_count / 24.0),
                TotalResults = result.pagination.total_count
            };
            return View(searchViewModel);
            //return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
