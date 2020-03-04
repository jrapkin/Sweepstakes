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
		public static string TakeUserInput()
		{
			string userInput = Console.ReadLine();
			return userInput;
		}
	}
}
