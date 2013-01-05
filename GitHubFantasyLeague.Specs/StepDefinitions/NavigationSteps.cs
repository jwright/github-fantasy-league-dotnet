using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GitHubFantasyLeague.Specs.StepDefinitions
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
