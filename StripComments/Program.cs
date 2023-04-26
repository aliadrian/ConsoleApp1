using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace StripComments
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(MultiplicationTable(3));
		}

		public static int[] MultiplicationTable(int size)
		{
			int[] result = new int[] { };
			for (int i = 1; i <= size; i++)
			{
				int[] multiplication = new int[i];
				Console.Write("[");

				for (int j = 1; j <= size; j++)
				{
					multiplication = new int[i * j];
					Console.Write($"{multiplication.Length},");
				}

				Console.WriteLine("]");
				result = multiplication;
			}
			return result;
		}
	}
}