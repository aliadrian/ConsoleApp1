using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace reverseString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(ReverseString("Welcome"));
		}

		public static string ReverseString(string str)
		{
			string[] words = str.Split(' ');
			string newString = "";
			string notReversed = "";

			foreach (string word in words)
			{
				if (word.Length >= 5)
				{
					newString += new string(word.ToCharArray().Reverse().ToArray()) + ' ';
				}
				else
				{
					notReversed += word + ' ';
				}
			}
			return (notReversed + newString).Trim();
		}
	}
}
