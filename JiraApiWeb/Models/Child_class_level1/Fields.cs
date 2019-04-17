using JiraWebApi.Child_class_level2;
using JiraWebApi.Child_class_level2_for_Fields_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi
{
	class Fields
	{
		public object statuscategorychangedate { get; set; }
		public Issuetype issuetype { get; set; }
		public int timespent { get; set; }
		public Project project { get; set; }
		public List<object> fixVersions { get; set; }
		public int aggregatetimespent { get; set; }
		public object customfield_10112 { get; set; }
		public object resolution { get; set; }
		public object customfield_10113 { get; set; }
		public Customfield10114 customfield_10114 { get; set; }
		public object resolutiondate { get; set; }
		public int workratio { get; set; }
		public Watches watches { get; set; }
		public DateTime lastViewed { get; set; }
		public DateTime created { get; set; }
		public DateTime customfield_10100 { get; set; }
		public Priority priority { get; set; }
		public object customfield_10101 { get; set; }
		public List<object> labels { get; set; }
		public object customfield_10214 { get; set; }
		public object customfield_10215 { get; set; }
		public object customfield_10216 { get; set; }
		public object customfield_10217 { get; set; }
		public int aggregatetimeoriginalestimate { get; set; }
		public int timeestimate { get; set; }
		public List<object> versions { get; set; }
		public List<Issuelink> issuelinks { get; set; }
		public Assignee assignee { get; set; }
		public DateTime updated { get; set; }
		public Status status { get; set; }
		public List<object> components { get; set; }
		public int timeoriginalestimate { get; set; }
		public Description description { get; set; }
		public object customfield_10210 { get; set; }
		public object customfield_10211 { get; set; }
		public object customfield_10212 { get; set; }
		public object customfield_10213 { get; set; }
		public Timetracking timetracking { get; set; }
		public string customfield_10005 { get; set; }
		public object security { get; set; }
		public Customfield10206 customfield_10206 { get; set; }
		public int aggregatetimeestimate { get; set; }
		public List<Attachment> attachment { get; set; }
		public object customfield_10207 { get; set; }
		public object customfield_10208 { get; set; }
		public List<object> customfield_10209 { get; set; }
		public string summary { get; set; }
		public Creator creator { get; set; }
		public List<object> subtasks { get; set; }
		public Reporter reporter { get; set; }
		public string customfield_10000 { get; set; }
		public Aggregateprogress aggregateprogress { get; set; }
		public object customfield_10001 { get; set; }
		public object customfield_10200 { get; set; }
		public List<string> customfield_10115 { get; set; }
		public string customfield_10116 { get; set; }
		public object duedate { get; set; }
		public Progress progress { get; set; }
		public Votes votes { get; set; }
		public Comment comment { get; set; }
		public Worklog worklog { get; set; }
	}
}
