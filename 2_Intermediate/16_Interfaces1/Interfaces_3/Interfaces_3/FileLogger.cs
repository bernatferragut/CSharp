using System;
using System.IO;

namespace Interfaces_3
{
	public class FileLogger : ILogger
	{
		private readonly string _path;

		public FileLogger(string path)
		{
			_path = path;
		}

		public void LogError(string message)
		{
			Log(message, "ERROR");
		}

		public void LogInfo(string message)
		{
			Log(message, "INFO");
		}

		private void Log(string message, string messageType)
		{
			using (var streamWriter = new StreamWriter(_path, true)) //  because of CLR
			{
				streamWriter.WriteLine(messageType + ":" +  message);
			}
		}
	}
}
