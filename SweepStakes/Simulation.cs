using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class Simulation 
	{
		Random random;
		MarketingFirm newFirm;
		SweepstakesQueueManager queue;
		SweepstakesStackManager stack;

		public void CreateMarketingFirmWithManager()
		{
			bool firmIsDeciding = true;
			do
				switch (UserInterface.TakeUserInput().ToLower())
				{
					case "1":
					case "queue":
						newFirm = new MarketingFirm(queue, random);
						firmIsDeciding = false;
						break;
					case "2":
					case "stack":
						newFirm = new MarketingFirm(stack, random);
						firmIsDeciding = false;
						break;
				}
			while (firmIsDeciding == true);
		}

	}
}
