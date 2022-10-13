using GiphyApi.Models;
using GiphyApi.Services;
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

        public async Task<IActionResult> Search(string GiphyTitle)
        {
            //ViewBag.Result = await giphyApiService.SearchByTitle(GiphyTitle);
            Rootobject result = await giphyApiService.SearchByTitle(GiphyTitle);
            //ViewBag.Result = result?.data[0]?.title;
            ViewBag.Result = result?.data?.title;
            /*ViewBag.Result = result.totalResults;
            ViewBag.MovieTitle = result?.Search[0]?.Title;*/
            return View(result);
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
