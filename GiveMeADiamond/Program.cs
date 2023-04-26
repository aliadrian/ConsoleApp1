using System.Linq;
using System.Text;

namespace GiveMeADiamond
{
	static internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Diamond(5));
		}

		public static string Repeat(this string str, int n)
		{
			var result = string.Empty;

			for (var i = 0; i < n; i++)
				result += str;

			return result;
		}

		public static string? Diamond(int n)
		{
			if (n < 0 || (n % 2 == 0))
			{
				return null;
			}

			int halfHeight = (n - 1) / 2;
			string diamond = "*".Repeat(n) + "\n";

			for (int i = 1; i <= halfHeight; i++)
			{
				int stars = n - i * 2;
				int extremeSpaces = i;

				string line = Repeat(" ", extremeSpaces) + Repeat("*", stars) + "\n";
				diamond = line + diamond + line;
			}

			return diamond;
		}
	}
}