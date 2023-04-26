using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace CountTheSmileyFaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CountTheSmileyFaces(new string[] { "P", ": D", "8~D" }));
		}

		public static int CountTheSmileyFaces(string[] smileys)
		{
			int count = 0;

			foreach (string smiley in smileys)
			{
				if (!smiley.Any(Char.IsWhiteSpace))
				{
					if (smiley.Contains(";") && smiley.Contains(")") || smiley.Contains(":") && smiley.Contains(")") || smiley.Contains(":") && smiley.Contains("D") || smiley.Contains(";") && smiley.Contains("D"))
					{
						count++;
					}
					else
					{
						continue;
					}
				}
			}

			return count;
		}
	}
}