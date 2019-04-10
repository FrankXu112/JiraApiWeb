using JiraWebApi.Child_class_level3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi
{
	class Project
	{
		public string self { get; set; }
		public string id { get; set; }
		public string key { get; set; }
		public string name { get; set; }
		public string projectTypeKey { get; set; }
		public AvatarUrls avatarUrls1 { get; set; }

	}
}
