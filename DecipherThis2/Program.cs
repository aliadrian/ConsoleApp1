using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;

namespace DecipherThis
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(DecipherThis(""));
		}

		public static string DecipherThis(string s)
		{
			StringBuilder sb = new StringBuilder();
			string[] words = s.Split(' ');
			if (s.Length > 0)
			{
				foreach (string word in words)
				{
					string resultString = Regex.Match(word, @"\d+").Value;
					int i = Convert.ToInt32(resultString);
					string converted = Char.ConvertFromUtf32(i);

					string newString = word.Substring(resultString.Length);
					string result = converted + newString;

					if (result.Length > 1)
					{
						char[] charArray = result.ToCharArray();
						char temp = charArray[1];
						charArray[1] = charArray[result.Length - 1];
						charArray[result.Length - 1] = temp;
						result = new string(charArray);
					}

					sb.Append(result);
					sb.Append(' ');
				}
			}
			else
			{
				return "";
			}

			return sb.ToString().Trim();
		}
	}
}