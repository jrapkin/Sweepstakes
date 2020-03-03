using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	public class Contestant
	{
		//member variables
		public string FirstName;
		public string LastName;
		public string EmailAddress;
		public int RegistrationNumber;


		

		//ctor
		public Contestant()
		{
			RetrieveContestantInformation();
		}

		private void RetrieveContestantInformation()
		{
			UserInterface.DisplayMessage("Please enter your first name:");
			FirstName = UserInterface.TakeUserInput();
			UserInterface.DisplayMessage("Please enter your last name:");
			LastName = UserInterface.TakeUserInput();
			UserInterface.DisplayMessage("Please enter your email address:");
			EmailAddress = UserInterface.TakeUserInput();
		}

	}
}
