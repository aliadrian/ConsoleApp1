namespace RemoveStringSpaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(RemoveWhiteSpaces("8 j 8   mBliB8g  imjB8B8  jl  B"));
		}

		public static string RemoveWhiteSpaces(string input)
		{
			string[] strings = input.Split(' ');
			string newString = String.Empty;

			foreach (string s in strings)
			{
				if (s.Length > 0)
				{
					newString += s;
				}
			}

			return newString;
		}
	}
}