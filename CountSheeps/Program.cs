using System.Linq;

namespace CountSheeps
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CountSheeps(new bool[] { true, false }));
		}

		public static int CountSheeps(bool[] sheeps)
		{
			//int count = 0;
			//foreach (var b in sheeps.Where(n => n != null))
			//{
			//	if (b == true)
			//	{
			//		count++;
			//	}
			//}

			//return count;

			return sheeps.Count(s => s);
		}
	}
}