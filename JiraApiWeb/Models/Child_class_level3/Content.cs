using JiraWebApi.Child_class_level4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level3
{
	class Content
	{
		public string type { get; set; }
		public Attrs attrs { get; set; }
		public List<Content2> content { get; set; }

	}
}
