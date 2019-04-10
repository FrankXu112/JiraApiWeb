using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level3
{
	class OutwardIssue
	{
		public string id { get; set; }
		public string key { get; set; }
		public string self { get; set; }
		public Fields2 fields { get; set; }

	}
}
