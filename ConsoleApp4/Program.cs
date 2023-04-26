using System.Globalization;
using System.Net.Http.Headers;

namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(covfefe("coverage coverage adrian"));
		}

		public static string covfefe(string str)
		{
			string[] words = str.Split(' ');
			string manyString = "";
			string covfefe = "covfefe";

			{
				for (int i = 0; i < words.Length; i++)
				{
					manyString += words[i].Replace(words[i], covfefe) + " ";
					manyString = words[i].ToLower() + " " + manyString;
				}
				return manyString;
			}
			//string s = "";

			//if (str.Contains("coverage"))
			//{
			//	s = str.Replace("coverage", "covfefe");
			//}
			//return s;
		}
	}
}