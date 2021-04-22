using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resume_application.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static Resume_application.Models.Constants;


namespace Resume_application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(ILogger<HomeController> logger,  IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
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

        public IActionResult DnDTesting()
        {
            return View();
        }

        [HttpGet]
        public async Task<string> GetDnDSpell(string spellName)
        {
            var spellClient = _clientFactory.CreateClient(DND_API);
            var DnDAPI = await spellClient.GetAsync("/api/spells/" + spellName + "/");
            return await DnDAPI.Content.ReadAsStringAsync();
        }
    }
}
