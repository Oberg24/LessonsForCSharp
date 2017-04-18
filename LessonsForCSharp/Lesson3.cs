using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForCSharp {
	public class Lesson3 {

		public static void RunBeforeCodereview() {

			var s = "This" + " is" + " a" + " string";
			Console.WriteLine(s);

			var v = 15;
			var t = "This is " + v.ToString() + " a value";
			Console.WriteLine(t);

			var x = "This is the start.";
			x += "Some more text";
			x += "And even more";
			Console.WriteLine(x);

			Console.ReadKey();

		}

		public static void RunAfterCodereview() {

			var s = string.Concat("This", " is", " a", " string");
			Console.WriteLine(s);

			var v = 15;
			var t = string.Format("This is {0} a value", v);
			Console.WriteLine(t);


			var x = @"This is the start.
								Some more text
								And even more";

			Console.WriteLine(x);

			StringBuilder bldr = new StringBuilder();
			bldr.Append("This is the start");
			bldr.AppendFormat("Foo bar {0}", 1);
			bldr.AppendLine();

			Console.WriteLine(bldr);


			Console.ReadKey();

		}


	}
}
