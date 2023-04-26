using System.Text.RegularExpressions;

namespace NotVerySecure
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Alphanumeric(""));
		}

		public static bool Alphanumeric(string str)
		{
			var regexItem = new Regex("[^A-Za-z0-9]");

			if (!regexItem.IsMatch(str) && !String.IsNullOrEmpty(str))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}