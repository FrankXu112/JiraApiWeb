using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Atlassian.Jira;

namespace JiraApiWeb.Models
{
	public class JiraDataCalculation
	{
		public IssueTimeTrackingData timeT = await GetTimeTrackingDataAsync();
		public int GetEstimateInMin()
		{
			return timeT["OriginalEstimateInseconds"]/60;
		}

		public int GetTimeSpentInMin()
		{
			return timeT["TimeSpentInSeconds"] / 60;
		}

		public Boolean CheckTicketOpen()
		{
			string stat = Atlassian.Jira.IssueStatus.ToString();
			if(stat = "open")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public WorkLogEntry[] GetEntries(DateTime startDate, DateTime endDate, IEnumerable<string> jiraProjectKeys)

		{

			if (jiraProjectKeys == null || !jiraProjectKeys.Any())
				
				return new Atlassian.Jira.WorkLogEntry[0];


			var jqlQuery = string.Format("project in ({0}) AND updated >= {1} AND updated <= {2}",

				string.Join(", ", jiraProjectKeys),

				startDate.ToString("yyyy-MM-dd"),

				endDate.ToString("yyyy-MM-dd")

				);



			var recentlyUpdatedIssues = Jira.GetIssuesByQuery(jqlQuery);

			var tasks = new List<Task<List<WorkLogEntry>>>();

			foreach (var issue in recentlyUpdatedIssues)
			{
				tasks.Add(GetWorkLogEntriesAsync(startDate, endDate, issue));
			}


			Task.WaitAll(tasks.ToArray());

			return tasks.SelectMany(t => t.Result).ToArray();

		}

		private Task<List<WorkLogEntry>> GetWorkLogEntriesAsync(DateTime startDate, DateTime endDate, Issue<IssueFields> issue)
			
		{
			return Task.Run(() =>

			   Jira.GetWorklogs(new IssueRef() { id = issue.id })

								   .Where(workLog => workLog.started >= startDate

												   && workLog.started.AddSeconds(workLog.timeSpentSeconds) <= endDate

												   && ((workLog?.author?.name == _username) || (workLog?.author?.emailAddress == _username)))

								   .Select(wl => new WorkLogEntry(wl, issue.key))
								   .ToList()

			);

		}



		public OperationResult UpdateWorkLog(WorkLogEntry entry)
		{
			try

			{
				Jira.UpdateWorklog(
					new IssueRef() { id = entry.IssueKey },

					new Worklog()
					{
						id = entry.Id,
						comment = entry.Description,
						started = entry.Start,
						timeSpentSeconds = (int)entry.RoundedDuration.TotalSeconds
					});
				return OperationResult.Success(entry);
			}

			catch (Exception ex)
			{
				return OperationResult.Error(ex.Message, entry);
			}
		}



		public OperationResult DeleteWorkLog(WorkLogEntry entry)
		{
			try
			{
				Jira.DeleteWorklog(new IssueRef() { id = entry.IssueKey }, new Worklog() { id = entry.Id });
				return OperationResult.Success(entry);
			}

			catch (Exception ex)
			{
				return OperationResult.Error(ex.Message, entry);
			}

		}



		public OperationResult AddWorkLog(WorkLogEntry entry)
		{
			try
			{
				var timeSpentSeconds = (int)entry.RoundedDuration.TotalSeconds;

				Jira.CreateWorklog(new IssueRef { id = entry.IssueKey }, timeSpentSeconds, entry.Description, entry.Start);

				return OperationResult.Success(entry);
			}

			catch (Exception ex)
			{
				return OperationResult.Error(ex.Message, entry);
			}

		}



		private static Issue ConvertToIncident(Atlassian.Jira.Issue<IssueFields> issue)
		{

			return new Issue
			{
				Key = issue.key,
				Summary = issue.fields.summary
			};

		}



		public string GetUserInformation()
		{
			return Jira.GetLoggedInUser().self;
		}
	}
}