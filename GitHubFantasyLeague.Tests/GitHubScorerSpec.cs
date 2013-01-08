using System;
using System.Collections.Generic;
using System.Linq;
using NSpec;
using GitHubFantasyLeague.Models;
using GitHub;

namespace GitHubFantasyLeague.Tests
{
    public class GitHubScorerSpec : nspec
    {
        void describe_score()
        {
            GitHubScorer subject = null;
            before = () =>
            {
                var data = new List<Event>();
                data.Add(new Event { Type = "CommitCommentEvent" });
                data.Add(new Event { Type = "IssuesEvent" });
                data.Add(new Event { Type = "IssueCommentEvent" });
                data.Add(new Event { Type = "WatchEvent" });
                data.Add(new Event { Type = "PullRequestEvent" });
                data.Add(new Event { Type = "PushEvent" });
                data.Add(new Event { Type = "FollowEvent" });
                data.Add(new Event { Type = "CreateEvent" });
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
