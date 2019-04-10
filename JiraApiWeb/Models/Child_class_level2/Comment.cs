using JiraWebApi.Child_class_level3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level2_for_Fields_
{
	class Comment
	{
		public List<Comment2> comments { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public int startAt { get; set; }

	}
}
