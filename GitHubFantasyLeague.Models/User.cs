using System;
using System.Collections.Generic;
using System.Linq;

namespace GitHubFantasyLeague.Models
{
    public class User
    {
        private string _username;
        private int? _totalScore;

        public string Username
        {
        	get	{ return _username; }
        }

        public int? TotalScore
        {
            get { return _totalScore; }
        }

        public static User Find(string username)
        {
            return new User(username);
        }

        public User Calculate()
        {
            _totalScore = 0;
            return this;
        }

        private User(string username)
        {
            _username = username;
        }
    }
}
