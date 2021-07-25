using Lab27Reddit.Data;
using Lab27Reddit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Reddit.Controllers
{
    public class HomeController : Controller
    {
        private readonly RedditDAL _redditPost = new RedditDAL();

        public async Task<IActionResult> Index()
        {
            var redditPost = await _redditPost.GetPostAsync();
            return View(redditPost);
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
