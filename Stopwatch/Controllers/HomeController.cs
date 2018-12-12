using Newtonsoft.Json;
using Stopwatch.Viewmodels;
using Stopwatch.Core.Business.Domain.MatchEndpoint;
using Stopwatch.Core.Business.Services.MatchEndpoint;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Stopwatch.Core.Infra.Enums;

namespace Stopwatch.Controllers
{
    public class HomeController : Controller
    {
        private IMatchService _matchService;
        public HomeController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public ActionResult Index(string summonerName)
        {            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> MatchList()
        {
            MatchListDto matchList = await _matchService.GetRecentMatchListAsync(RegionDto.euw, "Bommerhond");

            return View("Index");
        }
    }
}