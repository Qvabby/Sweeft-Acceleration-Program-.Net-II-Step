using System.Text.Json;
using System.IO;
//დავალება 8

//HTTP CLIENT to recieve api data.
using var client = new HttpClient();
client.BaseAddress = new Uri("https://restcountries.com/v3.1/all");
//Accept Json format.
client.DefaultRequestHeaders.Accept.Add(
    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
    );
try
{
    //Get Response from Countries API
    var response = await client.GetAsync("https://restcountries.com/v3.1/all");

    string filePath = "D://Countries";
    if (!Directory.Exists(filePath))
    {
        Directory.CreateDirectory("D://Countries");
    }

    //If response is successful
    if (response.IsSuccessStatusCode)
    {
        //Read response as string
        string data = await response.Content.ReadAsStringAsync();
        //Deserialize response to List of Country objects
        //Console.WriteLine(data);
        var countries = JsonSerializer.Deserialize<List<Country>>(data);

        //Print all countries
        foreach (var country in countries)
        {
            Console.WriteLine(country.name.common);

            using (StreamWriter sw = new StreamWriter(filePath + $"//{country.name.common}.txt", append: true))
            {
                sw.WriteLine($"region: {country.region}\nsubregion: {country.subregion}");
                sw.Write($"latlng: ");
                for (int i = 0; i < country.latlng.Length; i++)
                {
                    sw.Write(country.latlng[i] + ", ");
                }
                sw.Write($"\narea: {country.area}\npopulation: {country.population}");
            }
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//JSON Object.
public class Country
{
    public Name name { get; set; }
    public string region { get; set; }
    public string subregion { get; set; }
    public double[] latlng { get; set; }
    public double area { get; set; }
    public long population { get; set; }
}
public class Name
{
    public string common { get; set; }
    public string official { get; set; }
}