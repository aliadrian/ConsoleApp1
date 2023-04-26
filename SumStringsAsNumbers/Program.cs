using System.Numerics;

namespace SumStringsAsNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(SumStringsAsNumbers("123", "456"));
		}

		static string SumStringsAsNumbers(string a, string b)
		{
			// My solution that didn't work
			//BigInteger i = BigInteger.Parse(a) + BigInteger.Parse(b);

			//return i.ToString();

			// Correct solution
			BigInteger aInt;
			BigInteger bInt;

			BigInteger.TryParse(a, out aInt);
			BigInteger.TryParse(b, out bInt);

			return (aInt + bInt).ToString();
		}
	}
}