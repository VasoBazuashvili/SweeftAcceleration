using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics.Metrics;

public class Program
{
	public static void Main(string[] args)
	{
		GenerateCountryDataFiles();
		Console.WriteLine("Done");
	}

	public static async void GenerateCountryDataFiles()
	{
		Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");

		var httpClient = new HttpClient();
		var response = await httpClient.GetAsync("https://restcountries.com/v3.1/all");
		var content = await response.Content.ReadAsStringAsync();
		var countries = JsonConvert.DeserializeObject<Country[]>(content);
		response.EnsureSuccessStatusCode();

		if (response.IsSuccessStatusCode)
		{
			foreach (var country in countries)
			{
				var fileName = $"{country.Name.Common}.txt";
				var text = $"Region: {country.Region}\nSubregion: {country.Subregion}\nLatlng: {string.Join(",", country.Latlng)}\nArea: {country.Area}\nPopulation: {country.Population}";

				File.WriteAllText(fileName, text);
			}
		}
	}
	public class Country
	{
		public Name Name { get; set; }
		public string Region { get; set; }
		public string Subregion { get; set; }
		public double[] Latlng { get; set; }
		public double Area { get; set; }
		public int Population { get; set; }
	}

	public class Name
	{
		[JsonProperty("common")]
		public string Common { get; set; }
	}
}