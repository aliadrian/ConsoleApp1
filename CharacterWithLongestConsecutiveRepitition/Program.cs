using System;

namespace CharacterWithLongestConsecutiveRepitition
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(LongestRepetition(""));
		}

		public static Tuple<char?, int> LongestRepetition(string input)
		{

			if (input.Length <= 0)
			{
				var emptyTuple = Tuple.Create((char?)null, 0);

				return emptyTuple;
			}

			int[] charCount = new int[256];

			for (int i = 0; i < input.Length; i++)
			{
				charCount[input[i]]++;
			}

			int maxCount = -1;
			char character = ' ';

			for (int i = 0; i < input.Length; i++)
			{
				if (maxCount < charCount[input[i]])
				{
					maxCount = charCount[input[i]];
					character = input[i];
				}
			}

			return Tuple.Create((char?)character, maxCount);
		}
	}
}