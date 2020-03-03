using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class Sweepstakes
	{
		//member variables
		private string sweepstakesName;
		public string SweepstakesName
		{
			get { return sweepstakesName; }
			 
		}
		Dictionary<int, Contestant> contestants;
		public Sweepstakes(string name)
		{
			sweepstakesName = name;
			contestants = new Dictionary<int, Contestant>();
		}
		//member methods
		public void RegisterContestant (Contestant contestant)
		{
			
		}


	}
}
