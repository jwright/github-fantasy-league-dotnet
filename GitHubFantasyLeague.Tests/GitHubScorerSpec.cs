using System;
using System.Collections.Generic;
using System.Linq;
using NSpec;
using GitHubFantasyLeague.Models;

namespace GitHubFantasyLeague.Tests
{
    public class GitHubScorerSpec : nspec
    {
        void describe_score()
        {
            GitHubScorer subject = null;
            before = () =>
            {
                var data = new List<string>();
                data.Add("CommitCommentEvent");
                data.Add("IssuesEvent");
                data.Add("IssueCommentEvent");
                data.Add("WatchEvent");
                data.Add("PullRequestEvent");
                data.Add("PushEvent");
                data.Add("FollowEvent");
                data.Add("CreateEvent");
                subject = new GitHubScorer(data);
            };
            it["should parse events"] = () =>
            {
                subject.Score().Events.Count().should_be(8);
            };

            it["should calculate the total score"] = () =>
            {
                subject.Score().TotalScore.should_be(24);
            };
        }
    }
}
