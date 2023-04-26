using System.Runtime.CompilerServices;

namespace CamelCase
{
	public static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CamelCase(""));
		}

		public static string CamelCase(this string str)
		{
			string[] camelCase = str.TrimStart().Split(" ");
			string newString = string.Empty;

			foreach (string s in camelCase)
			{
				if (s.Length > 0)
				{
					newString += s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1);
				}
			}

			return newString;
		}
	}
}