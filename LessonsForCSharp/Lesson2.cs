using System;

namespace LessonsForCSharp {
	public class Lesson2 {

		public static void RunAfterCodeReview() {

			var test = true;

			if (test) {
				Console.WriteLine("Is it true");
			}

			if (test) Console.WriteLine("It is still true");
			
			if (test) {
				Console.WriteLine("Yup true");
				Console.WriteLine("More true");
			}		
			
			Console.ReadKey();

		}

		public static void RunBeforeCodeReview() {

			var test = true;

			if (test) {
				Console.WriteLine("Is it true");
			}

			if (test)
				Console.WriteLine("It is still true");

			if (test) 
				Console.WriteLine("Yup true");
				Console.WriteLine("More true");
			
			Console.ReadKey();

		}

	}
}
