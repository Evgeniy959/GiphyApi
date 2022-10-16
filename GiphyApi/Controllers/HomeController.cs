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
        private readonly IGiphyApiService giphyApiService;

        public HomeController(ILogger<HomeController> logger, IGiphyApiService giphyApiService)
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
                TotalCount = result.pagination.total_count
            };
            return View(searchViewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            var details = await giphyApiService.SearchById(id);
            Console.WriteLine("Details - " + id);
            return View(details);
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
