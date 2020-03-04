﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class SweepstakesQueueManager : ISweepstakesManager
	{
		private Queue<Sweepstakes> queue;
		public SweepstakesQueueManager()
		{
			queue = new Queue<Sweepstakes>();
		}
		public void InsertSweepstakes(Sweepstakes sweepstakes)
		{
			queue.Enqueue(sweepstakes);
		}
		public Sweepstakes GetSweepstakes()
		{
			return queue.Dequeue();
		}
	}
}
