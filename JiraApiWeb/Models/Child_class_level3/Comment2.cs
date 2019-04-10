using JiraWebApi.Child_class_level4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level3
{
	class Comment2
	{
		public string self { get; set; }
		public string id { get; set; }
		public Author author2 { get; set; }
		public Body body { get; set; }
		public UpdateAuthor updateAuthor { get; set; }
		public DateTime created { get; set; }
		public DateTime updated { get; set; }
		public bool jsdPublic { get; set; }

	}
}
