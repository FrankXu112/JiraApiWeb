using JiraWebApi.Child_class_level3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level2_for_Fields_
{
	class Worklog
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Worklog2> worklogs { get; set; }

	}
}
