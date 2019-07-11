using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Atlassian.Jira;

namespace JiraApiWeb.Models
{
	public class JiraDBConnecter
	{
		public async Task<List<Jira>> GetJira(string state)
		{
			var paramColl = new List<DbParameter>();
			AddInParam(paramColl, "@state", SqlDbType.NVarChar, state);
			return await ExcuteDataReader(connStr, "GetJira", paramColl,
			(render) =>
			{
				return new Jira
				{
					key = GetValue<long>(reader, "key"),
					assignee = GetValue<string>(reader, "assignee"),
					reporter = GetValue<string>(reader, "reporter"),
					createdAt = GetValue<DateTime>(reader, "createdAt"),
					closedAt = GetValue<DateTime>(reader, "closedAt"),
					status = GetValue<string>(reader, "status"),
					priority = GetValue<string>(reader, "priority"),
					type = GetValue<string>(reader, "type"),
					sprint = GetValue<string>(reader, "sprint"),
					description = GetValue<string>(reader, "description"),
					fixVersion = GetValue<long>(reader, "fixVersion"),
					technicalValue = GetValue<string>(reader, "technicalValue"),
					timeEstimate = GetValue<string>(reader, "timeEstimate"),
					timeSpent = GetValue<string>(reader, "timeSpent"),
				};
			});
		}

		private Task<List<Jira>> ExcuteDataReader(object connStr, string v, List<DbParameter> paramColl, Func<DbDataReader, Jira> p)
		{
			throw new NotImplementedException();
		}

		private void AddInParam(List<DbParameter> paramColl, string v, SqlDbType sqlDbType, object nVrChar, string state)
		{
			throw new NotImplementedException();
		}

		public async Task<List<T>> ExcuteDataReader<T>(string connStr, string sql, List<DbParameter> paramList, 
			Func<DbDataReader, T> transformer, CommandType commandType = CommandType.StoredProcedure)
		{
			using (var conn = new SqlConnection(connStr))
			{
				using (var reader = await ExcuteDataReader(conn, sql, paramList, commandType))
				{
					var ret = new List<T>();
					if (null != reader)
					{
						if (reader.HasRows)
						{
							while (await reader.ReadAsync())
							{
								ret.Add(transformer(reader));
							}
						}

						while (await reader.NextResultAsync())
						{

						}
					}
					conn.Close();
					return ret;
				}
			}
		}
	}

	public async Task SaveIssueAsync(List<Issue> issues)
	{
		var paramColl = new List<DbParameter>();
		
		DataTable issueDataTable = new DataTable();

		issueDataTable.Columns.Add("Key", typeof(long));
		issueDataTable.Columns.Add("Assignee", typeof(string));
		issueDataTable.Columns.Add("Reporter", typeof(string));
		issueDataTable.Columns.Add("Created_At", typeof(DateTime));
		issueDataTable.Columns.Add("Closed_At", typeof(DateTime));
		issueDataTable.Columns.Add("Status", typeof(string));
		issueDataTable.Columns.Add("Priorty", typeof(string));
		issueDataTable.Columns.Add("Type", typeof(string));
		issueDataTable.Columns.Add("Sprint", typeof(string));
		issueDataTable.Columns.Add("Description", typeof(string));
		issueDataTable.Columns.Add("Fix_Version", typeof(string));
		issueDataTable.Columns.Add("Technical_Value", typeof(string));
		issueDataTable.Columns.Add("Time_Estimate", typeof(long));
		issueDataTable.Columns.Add("Time_Spent", typeof(long));

		issues.ForEach(x => issueDataTable.Rows.Add(x.Key, x.Assignee, x.Reporter, x.Created, x.Closed, x.Status, x.Priority, x.Type, x.Sprint, x.Description, x.FixVersions, x.technicalValues, x.TimeTrackingData.OriginalEstimateInSeconds, x.TimeTrackingData.TimeSpent))

		AddInParam(paramColl, "@issues", SqlDbType.Structured, issueDataTable);

		await ExecuteNonQuery(connStr, "dbo.issues", paramColl);
	}

	public async Task SaveIssueDetailsAsync(List<IssueDetail> issueDetails)
	{
		var paramColl = new List<DbParameter>();
		DataTable issueDetailsDataTable = new DataTable();

		issueDetailsDataTable.Columns.Add("Users", typeof(List<User>));
		issueDetailsDataTable.Columns.Add("Work_Time_Today", typeof(long));
		issueDetailsDataTable.Columns.Add("Is_Reopned", typeof(Boolean));
		issueDetailsDataTable.Columns.Add("Reopned_Times", typeof(long));
		issueDetailsDataTable.Columns.Add("Last_User_closed", typeof(string));

		issueDetails.ForEach(x => issueDetailsDataTable.Rows.Add(x.users, x.workTimetoday, x.isReopend, x.reopendTimes, x.lastUserClosed));

		AddInParam(paramColl, "@issueDetails", SqlDbType.Structured, issueDetailsDataTable);

		await ExecuteNonQuery(connStr, "dbo.issues", paramColl);
	}
}