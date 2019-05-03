using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Atlassian.Jira;

namespace JiraApiWeb.Models
{
	public class JiraWorklog
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Atlassian.Jira.Worklog> worklogs { get; set; }
	}
}