using System.Security.Principal;

namespace GoingBackwards
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Number(156));
		}

		public static int[] Number(int sums)
		{
			int k = 0;

			int y = Convert.ToInt32(sums.ToString().Length);
			int[] numbers = new int[y];

			foreach (var i in sums.ToString())
			{
				int x = Convert.ToInt32(Char.ConvertFromUtf32(i));

				numbers[k] = x;
				k++;
			}

			int z = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				int o = numbers[i] - i;

				for (int j = i + 1; j < numbers.Length; j++)
				{
					int u = o + numbers[j] - i;
					numbers[z] = u;
					z++;
				}
			}
			foreach (var item in numbers)
			{
				Console.Write($"{item},");
			}
			return numbers;
		}
	}
}