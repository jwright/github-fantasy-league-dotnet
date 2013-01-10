github fantasy league (.NET)
===========================================
***

## DESCRIPTION

Compare Github users. It queries Github using the activity stream for a given username (https://github.com/{username}.json). This is the same problem presented to [Aaron Patterson](https://peepcode.com/products/play-by-play-tenderlove-ruby-on-rails) and [Yehuda
Katz](https://peepcode.com/products/play-by-play-wycats-i-ruby-on-rails) for the Play by Play by [PeepCode](http://peepcode.com).

The Ruby version of this code is deployed at [http://githubfantasy.com](http://githubfantasy.com).

A Ruby version of this same application is available at [github-fantasy-league](https://github.com/jwright/github-fantasy-league).

### Scoring system

The score is calculated based on the following activity stream's events.

* CommitCommentEvent - 2pts
* IssueCommentEvent - 2pts
* IssuesEvent - 3pts
* WatchEvent - 1pt
* PullRequestEvent - 5pts
* PushEvent - 7pts
* FollowEvent - 1pt
* CreateEvent - 3pts

## WALKTHROUGH

The walkthrough videos will be up shortly.
