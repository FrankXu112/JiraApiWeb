using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace JiraApiWeb.Models
{
	public class ReadJsonFiles
	{
		public static string GetFileFromDisk(string path)
		{
			var absPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return File.ReadAllText(absPath + path);
		}
	}
}