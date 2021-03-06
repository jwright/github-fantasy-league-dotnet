using System;
using System.Web.Mvc;
using RestfulRouting.Format;

namespace GitHubFantasyLeague.Controllers
{
    public abstract class ApplicationController : Controller
    {
        protected ActionResult RespondTo(Action<FormatCollection> format)
        {
            return new FormatResult(format);
        }
    }
}