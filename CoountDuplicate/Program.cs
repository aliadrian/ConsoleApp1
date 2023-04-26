namespace CoountDuplicate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(countDuplicate(new List<int>() { 1, 3, 1, 4, 5, 6, 3, 2 }));
		}

		public static int Occurance(List<int> arr, int x)
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

		public static int countDuplicate(List<int> numbers)
		{
			int count = 0;
			int nrOfOccurence = 0;
			int[] ints = numbers.ToArray();

			foreach (int i in numbers)
			{
				count = Occurance(numbers, i);
				if (count > i)
				{
					nrOfOccurence = count;
				}
				else if (nrOfOccurence > i)
				{
					nrOfOccurence = count;
				}

			}
			return nrOfOccurence;
		}
	}
}