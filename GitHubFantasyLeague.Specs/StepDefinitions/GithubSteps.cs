using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GitHubFantasyLeague.Specs.StepDefinitions
{
    [Binding]
    public class GithubSteps
    {
        [Given(@"I have a valid Github username")]
        public void GivenIHaveAValidGithubUsername()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter the Github username")]
        public void WhenIEnterTheGithubUsername()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the total score")]
        public void ThenIShouldSeeTheTotalScore()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
