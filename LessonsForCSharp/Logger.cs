using System;
using System.Text;
using System.IO;

namespace LessonsForCSharp {
	public static class Logger {

		static readonly string LOGNAME = "log.txt";
		static readonly int BUFFERSIZE = 255;

		public static void WriteLog(string msg, params object[] args) {
			var logEntry = string.Concat(string.Format(msg, args), Environment.NewLine);
			var encodedText = Encoding.UTF8.GetBytes(logEntry);
			WriteToDisk(encodedText);
		}

		private static void WriteToDisk(byte[] encodedText) {
			using (var stream = new FileStream(LOGNAME,
							FileMode.Append,
							FileAccess.Write,
							FileShare.None)) 
			{
				var written = 0;
				
				while (written < encodedText.Length) {					
					written += WriteToStream(encodedText, written, stream);
				}

				stream.Flush();
				stream.Close();
			}
		}

		private static int WriteToStream(byte[] encodedText, int written, FileStream stream) {
			var toWrite = (encodedText.Length - written - BUFFERSIZE) > 0 ? BUFFERSIZE : encodedText.Length - written;
			stream.Write(encodedText, written, toWrite);
			return toWrite;
		}
	}
}
