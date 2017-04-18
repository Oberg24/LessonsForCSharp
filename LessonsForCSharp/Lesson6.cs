using System;

namespace LessonsForCSharp {
	public class Lesson6 {
		
		public static void Run() {
			Console.WriteLine("{0} - {1}", pos, pType);

			Console.ReadKey();

		}

		static Position pos;
		static PitcherType pType;


		public enum Position {
			Invalid = 0,
			Pitcher,
			Catcher,
			FirstBase,
			SecondBase,
			ShortStop,
			ThirdBase,
			LeftField,
			CenterField,
			RightRield
		}

		public enum PitcherType {
			Unknown = 0,
			Starting = 1,
			LongRelief = 2,
			ShortRelief = 3,
			Setup = 4,
			Closer = 5
		}

	}
}
