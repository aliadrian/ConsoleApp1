using System.Net.WebSockets;
using System.Text.RegularExpressions;

namespace DecipherThis
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(DecipherThis("116tah"));
		}

		public static string DecipherThis(string s)
		{
			string[] words = s.Split(' ');
			string convertString = " ";

			foreach (string word in words)
			{
				string resultString = Regex.Match(word, @"\d+").Value;
				int i = Convert.ToInt32(resultString);
				string converted = Char.ConvertFromUtf32(i);
				string newString = word.Replace(resultString, converted);

				string lastLetter = newString.Substring(newString.Length - 1);

				char lastLetterInChar = Convert.ToChar(lastLetter);
				char secondLetter = newString[1];
				string result = newString.Replace(secondLetter, lastLetterInChar);
				string result2 = result.Substring(0, result.Length - 1);
				string result3 = result2 + secondLetter;
				convertString += result3 + ' ';
			}


			return convertString.Trim();
		}

	}
}