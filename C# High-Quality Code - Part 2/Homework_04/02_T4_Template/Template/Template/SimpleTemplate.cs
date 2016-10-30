namespace Template
{
	using System;
	using System.Collections.Generic;

	public class SimpleTemplate
	{
		// Returns the date from today.
		public static DateTime Today()
		{
			DateTime date = DateTime.Parse("04 октомври 2016 г.");
			return date;
		}

		// Prints the environment name.
		public static void PrintEnvironmentName()
		{
			string name = "SAGER-PC";

			List<string> fileNames = new List<string>()
			{
				name
			};

			foreach (string item in fileNames)
			{
				Console.WriteLine(item);
			}
		}

		// Prints the current file names of a selected path.
		public static void PrintCurrentFileNames(string currentPath)
		{
			if (System.IO.Directory.Exists(currentPath))
			{
				foreach (string item in System.IO.Directory.EnumerateFiles(currentPath))
				{
					Console.WriteLine(item.ToString());
				}				
			}
		}
	}
}