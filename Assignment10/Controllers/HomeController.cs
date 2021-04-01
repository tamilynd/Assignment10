using Assignment10.Models;
using Assignment10.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BowlingLeagueContext context {get; set;}

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext ctx)
        {
            _logger = logger;
            context = ctx;

        }

        public IActionResult Index(long? teamid, string teamname, int pageNum = 0)
        {
            int BowlersPerPage = 5;

            return View(new IndexViewModel
            {
                Bowlers = context.Bowlers
                .Where(b => b.TeamId == teamid || teamid == null)
                .Skip((pageNum - 1) * BowlersPerPage)
                .Take(BowlersPerPage)
                .AsEnumerable<Bowlers>(),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = BowlersPerPage,
                    CurrentPage = pageNum,

                    //If no team has been selected, then get the full count. If not only get a section
                    TotalNumItems = context.Bowlers
                    .Where(b => b.TeamId == teamid || teamid == null)
                    .Count()
                },
                TeamName = teamname
            }) ; 
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
