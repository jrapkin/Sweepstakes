using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
	public static class UserInterface
	{
		public static void DisplayMessage(string message)
		{
			Console.WriteLine(message);
		}
		public static void DisplayMessage(string message, int userID, Contestant contestant)
		{ 
			Console.WriteLine(message);
			Console.WriteLine(userID);
		}
		public static string TakeUserInput()
		{
			string userInput = Console.ReadLine();

			return userInput;
		}

	}
}
