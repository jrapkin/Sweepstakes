using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class MarketingFirm
	{
		Sweepstakes newSweepstakes;
		ISweepstakesManager manager;
		public MarketingFirm(ISweepstakesManager sweepstakesManager, Random random)
		{
			manager = sweepstakesManager;
		}

		public void CreateSweepstakes()
		{
			UserInterface.DisplayMessage("What would you like to name your sweepstakes?");
			newSweepstakes = new Sweepstakes(UserInterface.TakeUserInput());
		}
	}

}
