using System;

namespace LessonsForCSharp {
	public class SaveOrder {
		public string KurreNr { get; set; }
		public DateTime OrderDelivered { get; set; }
		public DateTime OrderSentToCoreSystem { get; set; }
		public TradeType TypeofTrade { get; set; }
		public SellType TypeOfSell { get; set; }
		public Channel ChannelId { get; set; }


		public SaveOrder(string kurreNr, DateTime orderDelivered, DateTime orderSentToCoreSystem, TradeType typeofTrade, SellType typeOfSell, Channel channelId) {
			KurreNr = kurreNr;
			OrderDelivered = orderDelivered; 
			OrderSentToCoreSystem = orderSentToCoreSystem;
			TypeofTrade = typeofTrade;
			TypeOfSell = typeOfSell;
			ChannelId = channelId;
		}
	}

	public enum TradeType {
		Securities = 0,
		Fund = 1
	}

	public enum Channel {
		IBF = 1,
		IBP = 2
	}

	public enum SellType {
		Buy,
		Sell,
		Change,
		NewlySubscribe,
		CreateFundDistribution,
		ChangeFundDistribution,
		OpenDepot,
		StartMonthSave,
		ChangeMonthSave
	}

}
