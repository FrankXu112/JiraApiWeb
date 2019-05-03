using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JiraApiWeb.Models
{
	public class JiraChangelog
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Atlassian.Jira.IssueChangeLog> histories { get; set; }
	}
}