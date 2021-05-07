using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resume_application.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static Resume_application.Infrastructure.Constants;
using Resume_application.DndAPI;

namespace Resume_application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IDndAPISpellService _dndAPISpellService;

        public HomeController(ILogger<HomeController> logger,  IHttpClientFactory clientFactory, IDndAPISpellService dndAPISpellService)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _dndAPISpellService = dndAPISpellService;
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
            var answer = await _dndAPISpellService.GetSpellByName(spellName);

            return answer;
        }
    }
}
