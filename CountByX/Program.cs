namespace CountByX
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CountBy(2, 5));
		}

		public static int[] CountBy(int x, int n)
		{
			int[] z = new int[n];

			for (int i = 0; i < n; i++)
			{
				if (i <= 0)
				{
					z[i] = x;
				}
				else
				{
					z[i] = x * (i + 1);
				}
			}

			return z;
		}
	}
}