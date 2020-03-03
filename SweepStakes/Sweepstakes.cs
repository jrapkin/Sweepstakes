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
		private Dictionary<int, Contestant> contestants;
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
		//member methods
		public void RegisterContestant (Contestant contestant)
		{
			contestant.RegistrationNumber = contestants.Count +1;
			contestants.Add(contestant.RegistrationNumber, contestant);
			potentialWinnerPool++;
		}
		public Contestant PickWinner(Random random)
		{
			int determineWinner = random.Next(1, potentialWinnerPool);
			Contestant winningContestant = contestants[determineWinner];
			return winningContestant;

		}
		public void PrintContestantInformation(Contestant contestant)
		{
			UserInterface.DisplayMessage($"Contestant information: \n Name: {contestant.FirstName} {contestant.LastName} \n Email: {contestant.EmailAddress}, \n Contestant ID: {contestant.RegistrationNumber}.");
		}
	}
}
