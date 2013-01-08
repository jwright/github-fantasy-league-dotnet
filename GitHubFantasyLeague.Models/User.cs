using System;
using System.Collections.Generic;
using System.Linq;
using GitHub;

namespace GitHubFantasyLeague.Models
{
    public class User
    {
        private string _username;
        private int? _totalScore;
        private GitHubScorer _scorer;

        public string Username
        {
        	get	{ return _username; }
        }

        public int? TotalScore
        {
            get { return _totalScore; }
        }

        private GitHubScorer Scorer
        {
            get
            {
                if (_scorer == null)
                {
                    IEnumerable<Event> data = new EventParser(_username).Get();
                    _scorer = new GitHubScorer(data).Score();
                }
                return _scorer;
            }
        }

        public static User Find(string username)
        {
            return new User(username);
        }

        public User Calculate()
        {
            _totalScore = Scorer.TotalScore;
            return this;
        }

        private User(string username)
        {
            _username = username;
        }
    }
}
