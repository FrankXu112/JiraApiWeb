using JiraWebApi.Child_class_level3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level2_for_Fields_
{
	class Attachment
	{
		public string self { get; set; }
		public string id { get; set; }
		public string filename { get; set; }
		public Author author { get; set; }
		public DateTime created { get; set; }
		public int size { get; set; }
		public string mimeType { get; set; }
		public string content { get; set; }
		public string thumbnail { get; set; }

	}
}
