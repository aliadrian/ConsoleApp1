using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;

namespace BasicEncryption
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Encrypt("gonxdcucpniozjovdcpiauznmoi", 388));
		}

		public static string Encrypt(string text, int rule)
		{
			string newChar = String.Empty;
			foreach (var c in text)
			{
				int x = Convert.ToInt32(c);
				int encrypted = (x + rule) % 256;

				if (encrypted < 0)
				{
					encrypted += 256;
				}

				newChar += Char.ConvertFromUtf32(encrypted);
			}

			return newChar;
		}
	}
}