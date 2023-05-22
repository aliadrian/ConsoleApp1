namespace Scramblies
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Scramble("aabbcamaomsccdd", "comma"));
		}

		public static bool Scramble(string str1, string str2)
		{
			string word = string.Empty;
			for (int i = 0; i < str2.Length; i++)
			{
				if (str1.Contains(str2[i]))
				{
					word += str2[i];
					str1 = str1.Remove(str1.IndexOf(str2[i]), 1);
				}
			}

			if (word == str2)
				return true;
			else
				return false;
		}
	}
}