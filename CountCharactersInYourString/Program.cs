namespace CountCharactersInYourString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Count("aabb"));
		}

		public static int occurance(char[] arr, int x)
		{
			int count = 0;
			foreach (int num in arr)
			{
				if (x == num)
				{
					count++;
				}
			}
			return count;
		}

		public static Dictionary<char, int> Count(string str)
		{
			Dictionary<char, int> charCounts = new Dictionary<char, int>();
			char[] chars = str.ToCharArray();

			foreach (var i in chars.Distinct())
			{
				int count = occurance(chars, i);
				Console.WriteLine(i + " Occurred For: " + count);
				charCounts.Add(i, count);
			}

			return charCounts;
		}
	}
}