namespace MeanSquareError
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Solution(new int[] { 0, -1 }, new int[] { -1, 0 }));
		}

		public static double Solution(int[] firstArray, int[] secondArray)
		{
			// My solution
			double[] z = new double[firstArray.Length];
			double sum = 0;

			for (int i = 0; i < firstArray.Length; i++)
			{
				double a = firstArray[i];
				double b = secondArray[i];
				double v = Math.Abs(a - b);

				z[i] = v * v;
			}

			foreach (var index in z)
			{
				sum += index;
			}

			double result = sum / firstArray.Length;

			return result;

			// Shorter solution
			//var dist = 0.00;

			//for (var i = 0; i < firstArray.Length; i++)
			//{
			//	dist += Math.Pow(firstArray[i] - secondArray[i], 2);
			//}

			//return dist / firstArray.Length;
		}
	}
}