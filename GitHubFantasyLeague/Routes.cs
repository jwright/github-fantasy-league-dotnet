using System.Web.Routing;
using RestfulRouting;
using GitHubFantasyLeague.Controllers;

[assembly: WebActivator.PreApplicationStartMethod(typeof(GitHubFantasyLeague.Routes), "Start")]

namespace GitHubFantasyLeague
{
    public class Routes : RouteSet
    {
        public override void Map(IMapper map)
        {
            map.DebugRoute("routedebug");
            map.Resources<UsersController>(u => { u.Only("create"); });
            map.Root<HomeController>(x => x.Index());
        }

        public static void Start()
        {
            var routes = RouteTable.Routes;
            routes.MapRoutes<Routes>();
        }
    }
}