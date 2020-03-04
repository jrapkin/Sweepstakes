using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	public class Contestant
	{
		public string FirstName;
		public string LastName;
		public string EmailAddress;
		public int RegistrationNumber;
		public Contestant()
		{
			SetContestantInformation();
		}
		private void SetContestantInformation()
		{
			UserInterface.DisplayMessage("Please enter contestant first name:");
			FirstName = UserInterface.TakeUserInput();
			UserInterface.DisplayMessage("Please enter contestant last name:");
			LastName = UserInterface.TakeUserInput();
			UserInterface.DisplayMessage("Please enter contestant a email address:");
			EmailAddress = UserInterface.TakeUserInput();
		}
	}
}
