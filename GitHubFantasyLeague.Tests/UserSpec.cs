using System;
using System.Collections.Generic;
using System.Linq;
using NSpec;
using GitHubFantasyLeague.Models;

namespace GitHubFantasyLeague.Tests
{
    public class UserSpec : nspec
    {
        void describe_find()
        {
            it["should return a new instance"] = () =>
            {
                User.Find("wycats").Username.should_be("wycats");
            };
        }

        void describe_calculate()
        {
            User subject = null;
            before = () => subject = User.Find("topfunky");

            it["should enable chaining"] = () =>
            {
                subject.Calculate().should_cast_to<User>();
            };

            it["should populate total score"] = () =>
            {
                subject.Calculate().TotalScore.should_not_be_null();
            };
        }
    }
}
