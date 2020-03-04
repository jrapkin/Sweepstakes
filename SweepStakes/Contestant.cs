using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	public class Contestant
	{
		public string firstName;
		public string lastName;
		public string emailAddress;
		public int registrationNumber;
		public Contestant()
		{
			SetContestantInformation();
		}
		private void SetContestantInformation()
		{
			UserInterface.DisplayMessage("Please enter contestant first name:");
			firstName = UserInterface.TakeUserInput();
			UserInterface.DisplayMessage("Please enter contestant last name:");
			lastName = UserInterface.TakeUserInput();
			UserInterface.DisplayMessage("Please enter contestant a email address:");
			emailAddress = UserInterface.TakeUserInput();
		}
	}
}
