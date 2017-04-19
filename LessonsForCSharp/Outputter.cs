using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForCSharp {
	public class Outputter {

		private Outputter() { }

		static Outputter _outputter = null;

		public static Outputter Instance {
			get 
				{
					if (_outputter == null) 
					{
					_outputter = new Outputter();
					}
				return _outputter;
			}		
		}

		public void Output(string s) {
			Console.WriteLine(s);
		}

	}
}
