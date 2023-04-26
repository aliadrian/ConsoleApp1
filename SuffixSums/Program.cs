namespace SuffixSums
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(SuffixSums(new int[] { 1, 123, 23 }));
		}

		public static int[] SuffixSums(int[] nums)
		{
			int[] sumAll = new int[nums.Length];

			int total = 0;
			int x = 0;
			for (int i = 0; i < nums.Length + 1; i++)
			{
				sumAll[x] = total;
				total = 0;
				if (i > 0)
					x++;
				for (int j = 0 + i; j < nums.Length; j++)
					total += nums[j];
			}

			return sumAll;
		}
	}
}