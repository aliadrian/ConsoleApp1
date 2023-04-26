using System;

namespace LINQ
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int countOfMovies = int.Parse(Console.ReadLine());

			var movies = new List<Movie>();
			for (int i = 0; i < countOfMovies; i++)
			{
				string str = Console.ReadLine();
				string[] strArr = str.Split(' ');
				movies.Add(new Movie
				{
					Title = strArr[0],
					Genre = strArr[1],
					Rating = int.Parse(strArr[2])
				});
			}

			Console.WriteLine($"Highest rating is {HighestRating(movies)}");
			Console.WriteLine($"Lowest rating is {LowestRating(movies)}");
			Console.WriteLine($"Average rating is {AverageRating(movies)}");
			foreach (var mv in HighestRatingForEachGenre(movies))
			{
				Console.WriteLine($"The highest rating for genre {mv.Key} is {mv.Value.Rating}. Movie's title is {mv.Value.Title}");
			}
		}

		public static Dictionary<string, Movie> HighestRatingForEachGenre(List<Movie> movies)
		{

			var q4 = movies
			.GroupBy(m => m.Genre)
			.OrderBy(genreGroup => genreGroup.Key)
			.Select(genreGroup =>
			{
				var highestRating = genreGroup.Max(m => m.Rating);
				return (Genre: genreGroup.Key, Movie: genreGroup.First(m => m.Rating == highestRating), Rating: highestRating);
			});

			return q4.ToDictionary(g => g.Genre, g => g.Movie);
		}

		public static object AverageRating(List<Movie> movies)
		{
			var q3 = movies
			.Average(m => m.Rating);
			return (int)q3;
		}

		public static object LowestRating(List<Movie> movies)
		{
			var q2 = movies
		   .Min(m => m.Rating);
			return q2;
		}

		public static object HighestRating(List<Movie> movies)
		{
			var q1 = movies
			.Max(m => m.Rating);
			return q1;
		}
	}

	public class Movie
	{
		public string? Title { get; set; }
		public string? Genre { get; set; }
		public int? Rating { get; set; }
	}
}