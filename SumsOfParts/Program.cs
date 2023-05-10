namespace SumsOfParts
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(PartsSums(new int[] { }));
		}
		// My way of writing it 
		//public static int[] PartsSums(int[] ls)
		//{
		//	List<int> list = new List<int>();

		//	for (int i = 0; i < ls.Length + 1; i++)
		//	{
		//		int sum = 0;
		//		for (int j = i; j < ls.Length; j++)
		//		{
		//			sum += ls[j];
		//		}
		//		list.Add(sum);
		//	}

		//	return list.ToArray();
		//}

		// Updated version of the code optimized
		public static int[] PartsSums(int[] ls)
		{
			int n = ls.Length;
			int[] result = new int[n + 1];
			int sum = 0;

			for (int i = n - 1; i >= 0; i--)
			{
				sum += ls[i];
				result[i] = sum;
			}

			return result;
		}
	}
}