using System;

namespace CGRepos.Models
    {

	/* MARK: - 
	 *
	 * TITLE: Repository Class Model
	 * DESCRIPTION: This class represents the model of the structured data 
	 * needed to populate the items for the table view and list view...
     *
     * AUTHOR: @gchriswill 
     */

	public class Repos
        {

        #region Class Computed Properties
        public string name { get; set; } = "";
        public string created_at { get; set; } = "";
        public string description { get; set; } = "";

		#endregion

		#region Class Constructors
		public Repos()
			{
			}

        public Repos(string name, string created_at, string description)
            {
            // Initialize
            this.name = name;
            this.created_at = created_at;
            this.description = description;
            }
        #endregion

        }
	}



/* MARK: - 
 *
 * COMMENT: This is an example of a single repository's JSON object from Github.
 * 
 * AUTHOR: @gchriswill 
 */

//"id": 33861053,
//"name": "testingaudio",
//"full_name": "gchriswill/testingaudio",
//"owner": {
//  "login": "gchriswill",
//  "id": 4576678,
//  "avatar_url": "https://avatars0.githubusercontent.com/u/4576678?v=4",
//  "gravatar_id": "",
//  "url": "https://api.github.com/users/gchriswill",
//  "html_url": "https://github.com/gchriswill",
//  "followers_url": "https://api.github.com/users/gchriswill/followers",
//  "following_url": "https://api.github.com/users/gchriswill/following{/other_user}",
//  "gists_url": "https://api.github.com/users/gchriswill/gists{/gist_id}",
//  "starred_url": "https://api.github.com/users/gchriswill/starred{/owner}{/repo}",
//  "subscriptions_url": "https://api.github.com/users/gchriswill/subscriptions",
//  "organizations_url": "https://api.github.com/users/gchriswill/orgs",
//  "repos_url": "https://api.github.com/users/gchriswill/repos",
//  "events_url": "https://api.github.com/users/gchriswill/events{/privacy}",
//  "received_events_url": "https://api.github.com/users/gchriswill/received_events",
//  "type": "User",
//  "site_admin": false
//},
//"private": false,
//"html_url": "https://github.com/gchriswill/testingaudio",
//"description": "Testing an audio html player...",
//"fork": false,
//"url": "https://api.github.com/repos/gchriswill/testingaudio",
//"forks_url": "https://api.github.com/repos/gchriswill/testingaudio/forks",
//"keys_url": "https://api.github.com/repos/gchriswill/testingaudio/keys{/key_id}",
//"collaborators_url": "https://api.github.com/repos/gchriswill/testingaudio/collaborators{/collaborator}",
//"teams_url": "https://api.github.com/repos/gchriswill/testingaudio/teams",
//"hooks_url": "https://api.github.com/repos/gchriswill/testingaudio/hooks",
//"issue_events_url": "https://api.github.com/repos/gchriswill/testingaudio/issues/events{/number}",
//"events_url": "https://api.github.com/repos/gchriswill/testingaudio/events",
//"assignees_url": "https://api.github.com/repos/gchriswill/testingaudio/assignees{/user}",
//"branches_url": "https://api.github.com/repos/gchriswill/testingaudio/branches{/branch}",
//"tags_url": "https://api.github.com/repos/gchriswill/testingaudio/tags",
//"blobs_url": "https://api.github.com/repos/gchriswill/testingaudio/git/blobs{/sha}",
//"git_tags_url": "https://api.github.com/repos/gchriswill/testingaudio/git/tags{/sha}",
//"git_refs_url": "https://api.github.com/repos/gchriswill/testingaudio/git/refs{/sha}",
//"trees_url": "https://api.github.com/repos/gchriswill/testingaudio/git/trees{/sha}",
//"statuses_url": "https://api.github.com/repos/gchriswill/testingaudio/statuses/{sha}",
//"languages_url": "https://api.github.com/repos/gchriswill/testingaudio/languages",
//"stargazers_url": "https://api.github.com/repos/gchriswill/testingaudio/stargazers",
//"contributors_url": "https://api.github.com/repos/gchriswill/testingaudio/contributors",
//"subscribers_url": "https://api.github.com/repos/gchriswill/testingaudio/subscribers",
//"subscription_url": "https://api.github.com/repos/gchriswill/testingaudio/subscription",
//"commits_url": "https://api.github.com/repos/gchriswill/testingaudio/commits{/sha}",
//"git_commits_url": "https://api.github.com/repos/gchriswill/testingaudio/git/commits{/sha}",
//"comments_url": "https://api.github.com/repos/gchriswill/testingaudio/comments{/number}",
//"issue_comment_url": "https://api.github.com/repos/gchriswill/testingaudio/issues/comments{/number}",
//"contents_url": "https://api.github.com/repos/gchriswill/testingaudio/contents/{+path}",
//"compare_url": "https://api.github.com/repos/gchriswill/testingaudio/compare/{base}...{head}",
//"merges_url": "https://api.github.com/repos/gchriswill/testingaudio/merges",
//"archive_url": "https://api.github.com/repos/gchriswill/testingaudio/{archive_format}{/ref}",
//"downloads_url": "https://api.github.com/repos/gchriswill/testingaudio/downloads",
//"issues_url": "https://api.github.com/repos/gchriswill/testingaudio/issues{/number}",
//"pulls_url": "https://api.github.com/repos/gchriswill/testingaudio/pulls{/number}",
//"milestones_url": "https://api.github.com/repos/gchriswill/testingaudio/milestones{/number}",
//"notifications_url": "https://api.github.com/repos/gchriswill/testingaudio/notifications{?since,all,participating}",
//"labels_url": "https://api.github.com/repos/gchriswill/testingaudio/labels{/name}",
//"releases_url": "https://api.github.com/repos/gchriswill/testingaudio/releases{/id}",
//"deployments_url": "https://api.github.com/repos/gchriswill/testingaudio/deployments",
//"created_at": "2015-04-13T09:59:26Z",
//"updated_at": "2016-01-20T08:31:38Z",
//"pushed_at": "2015-04-13T10:42:05Z",
//"git_url": "git://github.com/gchriswill/testingaudio.git",
//"ssh_url": "git@github.com:gchriswill/testingaudio.git",
//"clone_url": "https://github.com/gchriswill/testingaudio.git",
//"svn_url": "https://github.com/gchriswill/testingaudio",
//"homepage": "",
//"size": 2811,
//"stargazers_count": 0,
//"watchers_count": 0,
//"language": "HTML",
//"has_issues": true,
//"has_projects": true,
//"has_downloads": true,
//"has_wiki": true,
//"has_pages": true,
//"forks_count": 0,
//"mirror_url": null,
//"open_issues_count": 0,
//"forks": 0,
//"open_issues": 0,
//"watchers": 0,
//"default_branch": "gh-pages"