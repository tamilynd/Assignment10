using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Components
{
    public class TeamsViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;
        public TeamsViewComponent (BowlingLeagueContext ctx)
        {
            context = ctx;
        }
        public IViewComponentResult Invoke()
        {
            //Grab current team name (if there is one) and put it in the view bag
            ViewBag.SelectedTeam = RouteData?.Values["teamname"];
            return View(context.Teams);
        }
    }
}
