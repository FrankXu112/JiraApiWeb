using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JiraApiWeb.Models.Child_class_level3
{
	public class TypeInIssueLink
	{
		public string id { get; set; }
		public string name { get; set; }
		public string inward { get; set; }
		public string outward { get; set; }
		public string self { get; set; }
	}
}