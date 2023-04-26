namespace AllStarCodeChallenge
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Rotate("Hello"));
		}
		//private static int i;
		//public static string Rotate(string s)
		//{
		//	string newerString = string.Empty;
		//	i++;

		//	for (i = 0; i < s.Length; i++)
		//	{
		//		string newWord = s.Substring(0, s.Length - 1);
		//		char lastLetter = s[s.Length - 1];
		//		newerString = lastLetter + newWord;
		//		if (i < s.Length)
		//		{
		//			i++;
		//			Rotate(newerString);
		//		}
		//	}

		//	return newerString;
		//}

		public static List<string> Rotate(string str)
		{
			List<string> result = new List<string>();

			for (int i = 0; i < str.Length; i++)
			{
				result.Add(str.Substring(i + 1) + str.Substring(0, i + 1));
			}

			return result;
		}
	}
}