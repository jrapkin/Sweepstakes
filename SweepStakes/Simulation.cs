using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class Simulation 
	{
		private MarketingFirm newFirm;
		private SweepstakesQueueManager queue;
		private SweepstakesStackManager stack;

		public void CreateMarketingFirmWithManager()
		{
			bool isAValidInput = false;
			do
				switch (UserInterface.TakeUserInput().ToLower())
				{
					case "1":
					case "queue":
						newFirm = new MarketingFirm(queue);
						isAValidInput = true;
						break;
					case "2":
					case "stack":
						newFirm = new MarketingFirm(stack);
						isAValidInput = true;
						break;
					default:
						UserInterface.DisplayMessage("Not a valid input, please choose stack or queue.");
						break;
				}
			while (isAValidInput == false);
		}
	}
}
