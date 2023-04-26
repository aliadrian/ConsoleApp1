using System.Text.RegularExpressions;

namespace RemoveParentheses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(RemoveParentheses("hello example (words(more words) here) something"));
		}

		public static string RemoveParentheses(string s)
		{
			while (Regex.IsMatch(s, @"\([^()]*\)"))
			{
				s = Regex.Replace(s, @"\([^()]*\)", "");
			}
			return s;
		}
	}
}