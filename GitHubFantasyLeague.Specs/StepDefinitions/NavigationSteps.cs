using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using GitHubFantasyLeague.Specs.Support;

namespace GitHubFantasyLeague.Specs.StepDefinitions
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Engine.Current.Browser.GoTo("http://localhost:8232/");
        }

    }
}
