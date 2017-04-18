using System.IO;

namespace LessonsForCSharp {
	public class Lesson5 {

		public static void Run() {

			using (FileStream stream = new FileStream("c:\tes.ste", FileMode.Append)) {
				stream.Close();
			}		
			
		}
	}
}
