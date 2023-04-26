namespace MultiplicationTable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(MultiplicationTable(3));
		}

		public static int[,] MultiplicationTable(int size)
		{
			int[,] result = new int[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					result[i, j] = (i + 1) * (j + 1);
				}
			}

			return result;
		}
	}
}