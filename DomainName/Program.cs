using System.Reflection.Metadata.Ecma335;

namespace DomainName
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(DomainName("http://google.co.jp"));
		}

		static string DomainName(string domain)
		{
			string[] words = domain.Split('.');

			foreach (string word in words)
			{

				if (domain.Contains("https://"))
				{
					return domain.Substring(8, word.Length - 8);
				}
				else if (domain.Contains("http://"))
				{
					return domain.Substring(7, word.Length - 7);
				}
				else if (domain.Contains("www"))
				{
					return words[1].ToString();
				}
			}
			return "";
		}
	}
}