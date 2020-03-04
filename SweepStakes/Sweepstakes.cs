using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	class Sweepstakes
	{
		private string sweepstakesName;		
		private Dictionary<int, Contestant> contestants;
		Random random;
		public string SweepstakesName
		{
			get { return sweepstakesName; }
		}
		private int potentialWinnerPool;
		public Sweepstakes(string name)
		{
			sweepstakesName = name;
			contestants = new Dictionary<int, Contestant>();
		}
		public void RegisterContestant (Contestant contestant)
		{
			contestant.registrationNumber = contestants.Count +1;
			contestants.Add(contestant.registrationNumber, contestant);
			potentialWinnerPool++;
		}
		public Contestant PickWinner()
		{
			int determineWinner = random.Next(1, potentialWinnerPool);
			Contestant winningContestant = contestants[determineWinner];
			return winningContestant;
		}
		public void PrintContestantInformation(Contestant contestant)
		{
			UserInterface.DisplayMessage($"Contestant information: \n Name: {contestant.firstName} {contestant.lastName} \n Email: {contestant.emailAddress}, \n Contestant ID: {contestant.registrationNumber}.");
		}
	}
}
