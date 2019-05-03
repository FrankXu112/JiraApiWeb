using Atlassian.Jira;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace JiraApiWeb.Models
{
	class JiraApiHelper
	{
		private readonly Jira inner_client;
		public JiraApiHelper()
		{
			this.inner_client = Jira.CreateRestClient("http://bryczproject.atlassian.net", "frankxu@arctrade.com", "xxy921210");
		}

		public async Task<Issue> GetIssuseAsync()
		{
			var issue = await inner_client.RestClient.ExecuteRequestAsync<Issue>(Method.GET, $"/rest/api/3/issue/USG-979");

			return issue;
		}

		public List<Issue> GetAllIssusesAsync()
		{
			var issues = new List<Issue>();
			var search_result = inner_client.RestClient.ExecuteRequestAsync<Issue>(Method.GET, $"/rest/api/3/search?");
			foreach (var issue in search_result)
			{
				issues.Add(issue);
			}
			return issues;
		}

		static string PrepareJqlbyDates(string beginDate, string endDate)
		{
			string jqlString = "project = PRJ AND status = Closed AND resolved >= " + beginDate + " AND resolved <= " + endDate;

			return jqlString;
		}

		public List<User> GetAllUsers()

		{
			var users = new List<User>();

			var search_result = inner_client.RestClient.ExecuteRequestAsync<List<User>>(Method.GET,
				$"/rest/api/3/user/search?username=_&startAt=0&maxResults=2000");

			foreach (var user in search_result)
			{
				if (!users.Any(x => x.Key.Equals(user.Key, StringComparison.CurrentCultureIgnoreCase)))
					users.Add(user);
			}

			return users;
		}

	}
}
