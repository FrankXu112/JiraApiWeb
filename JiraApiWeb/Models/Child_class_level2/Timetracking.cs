using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraWebApi.Child_class_level2_for_Fields_
{
	class Timetracking
	{
		public string originalEstimate { get; set; }
		public string remainingEstimate { get; set; }
		public string timeSpent { get; set; }
		public int originalEstimateSeconds { get; set; }
		public int remainingEstimateSeconds { get; set; }
		public int timeSpentSeconds { get; set; }

	}
}
