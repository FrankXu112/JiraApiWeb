using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JiraApiWeb.Models
{
	public class User
	{
		public bool Active { get; set; }
		public string DisplayName { get; set; }
		public string EmailAddress { get; set; }
		public string Key { get; set; }
		public string Locale { get; set; }
		public string Name { get; set; }
		public string Self { get; set; }
		public string TimeZone { get; set; }
	}
}