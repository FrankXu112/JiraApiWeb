using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JiraApiWeb.Models
{
	public class IssueDetail
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int totalTimeSpent { get; set; }
		public List<User> users { get; set; }
		public int workTimetoday { get; set; }
		public Boolean isReopend { get; set; }
		public int reopendTimes { get; set; }
		public string lastUserClosed { get; set; }
	}
}