using System.Xml;

namespace Iamveryveryvery
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IAm("");
			IAm("");
			Console.WriteLine(IAm("sad"));
		}

		public static int numberOfInvokes = 0;
		public static string IAm(string input)
		{
			string output = string.Empty;
			List<string> list = new List<string>();
			numberOfInvokes++;

			if (numberOfInvokes > 1)
			{
				for (int i = 0; i < numberOfInvokes - 1; i++)
				{
					list.Add("very");
				}

				foreach (string s in list)
				{
					output += " " + s;
				}
				return "I am" + output + " " + input;
			}
			else
			{
				return "I am " + input;
			}
		}
	}
}