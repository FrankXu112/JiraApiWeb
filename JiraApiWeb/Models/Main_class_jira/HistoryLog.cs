
using JiraWebApi.Child_class_level1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Main_class_jira
{
	class HistoryLog
	{
		public string expand { get; set; }
		public string id { get; set; }
		public string self { get; set; }
		public string key { get; set; }
		public Changelog changelog { get; set; }
		public Fields fields { get; set; }
	}
}
