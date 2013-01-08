using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GitHubFantasyLeague.Controllers
{
    public class UsersController : ApplicationController
    {
        public ActionResult Create(string username)
        {
            ViewBag.TotalScore = Models.User.Find(username).Calculate().TotalScore;
            return View("new");
        }

    }
}
