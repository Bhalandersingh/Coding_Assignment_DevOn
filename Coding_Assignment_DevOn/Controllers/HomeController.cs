using System.Diagnostics;
using Coding_Assignment_DevOn.Models;
using LoggerLibrary;
using Microsoft.AspNetCore.Mvc;

namespace Coding_Assignment_DevOn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoggerManager _logger;
        //public HomeController(ILogger<HomeController> logger)
        public HomeController(ILoggerManager logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogDebug(nameof(HomeController), "test Log message 1");
            _logger.LogError(nameof(HomeController), "test Log message 2");
            _logger.LogInfo(nameof(HomeController), "test Log message 3");
            _logger.LogWarn(nameof(HomeController), "test Log message 4");
            _logger.LogDebug(nameof(HomeController), "test Log message 5");
            _logger.LogDebug(nameof(HomeController), "test Log message 6");
            _logger.LogDebug(nameof(HomeController), "test Log message 7");
            return View();
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
