using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class MarketingFirm
	{
		ISweepstakesManager manager;
		public MarketingFirm(ISweepstakesManager sweepstakesManager, Random random)
		{
			manager = sweepstakesManager;
		}


	}

}
