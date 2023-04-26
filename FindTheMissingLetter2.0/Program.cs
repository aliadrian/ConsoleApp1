namespace FindTheMissingLetter2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(FindMissingLetter2(new[] { 'o', 'q', 'r', 's' }));
		}

		public static char FindMissingLetter2(char[] array)
		{
			char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };

			string charArray = "";
			string alphabetArray = "";
			//string result = "";

			foreach (var item in array)
			{
				charArray += item.ToString();
			}

			foreach (var item in alphabet)
			{
				alphabetArray += item.ToString();
			}

			Console.WriteLine(charArray);
			Console.WriteLine(alphabetArray);

			if (charArray != alphabetArray)
			{

			}

			return ' ';
		}
	}
}