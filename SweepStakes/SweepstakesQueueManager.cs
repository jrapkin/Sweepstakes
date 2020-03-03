using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class SweepstakesQueueManager
	{
		Queue<Sweepstakes> queue;
		public SweepstakesQueueManager()
		{
			queue = new Queue<Sweepstakes>();
		}
	}
}
