using JiraWebApi.Child_class_level3;
using JiraWebApi.Model.Child_class_level3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Model.Child_class_level2
{
	class History
	{
		public string id { get; set; }
		public Author author { get; set; }
		public DateTime created { get; set; }
		public List<Item> items { get; set; }

	}
}
