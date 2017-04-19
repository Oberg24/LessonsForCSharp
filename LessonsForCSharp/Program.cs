using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForCSharp {
	class Program {
		static void Main(string[] args) {

			//Lesson2.RunBeforeCodeReview();
			//Lesson2.RunAfterCodeReview();

			//Lesson3.RunBeforeCodereview();
			//Lesson3.RunAfterCodereview();

			//Lesson6.Run();

			//Outputter.Instance.Output("Foo bar");

			//Outputter1.Output("Foo bar");
			var dateTime = DateTime.Now;
			var datum = dateTime.AddTicks(-1 * dateTime.Ticks % 10000);

			var saveOrder = new SaveOrder("test", datum, datum, TradeType.Fund, SellType.Buy, Channel.IBF);

			Console.WriteLine(saveOrder.ChannelId);
			Console.WriteLine(saveOrder.KurreNr);
			Console.WriteLine(saveOrder.OrderDelivered);
			Console.WriteLine(saveOrder.OrderSentToCoreSystem);
			Console.WriteLine(saveOrder.TypeOfSell);
			Console.WriteLine(saveOrder.TypeofTrade);

			Console.ReadKey();

		}
	}
}
