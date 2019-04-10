using JiraWebApi.Model.Child_class_level2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level1
{
	class Changelog
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<History> histories { get; set; }

	}
}
