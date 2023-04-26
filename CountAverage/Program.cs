namespace CountAverage
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(FindAverage(new double[] { }));
		}

		public static double FindAverage(double[] array)
		{
			// Two short solutions
			//return (array.Length == 0) ? 0 : array.Average();
			return array.DefaultIfEmpty().Average();
		}
	}
}