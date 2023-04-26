using System.Net.WebSockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AddAll
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AddAll();
		}

		static void AddAll()
		{
			int[] numbers = { 1, 2, 3 };
			int sum = 0;
			int values = 0;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				for (int j = i + 1; j < numbers.Length; j++)
				{
					sum += numbers[i] + numbers[j];
					values += numbers[i] + sum;
				}

			}
			Console.WriteLine(values);
		}
	}
}