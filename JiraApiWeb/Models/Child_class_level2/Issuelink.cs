using JiraWebApi.Child_class_level3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level2
{
	class Issuelink
	{
		public string id { get; set; }
		public string self { get; set; }
		public Type type { get; set; }
		public OutwardIssue outwardIssue { get; set; }

	}
}
