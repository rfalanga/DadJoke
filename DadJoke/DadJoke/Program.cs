// write a program that will tell a dad joke using the icanhazdadjoke API (https://icanhazdadjoke.com/api) and the HttpClient class.
// The program should make a GET request to the API and then print the joke to the console.
class Program
{
    static async Task Main(string[] args)
    {
        var joke = await GetDadJokeAsync();
        Console.WriteLine(joke);
    }

    static async Task<string> GetDadJokeAsync()
    {
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("DadJokeApp", "1.0"));

            var response = await client.GetAsync("https://icanhazdadjoke.com/");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();    // This retrieves the joke as a JSON string.
                var jokeResponse = System.Text.Json.JsonSerializer.Deserialize<JokeResponse>(jsonString);   // This deserializes the JSON string into a JokeResponse object, but it doesn't work yet because we haven't defined the JokeResponse class.
                return jokeResponse.Joke;
            }
            else
            {
                return "Failed to retrieve a joke.";
            }
        }
    }
}
// The program should be written in a way that allows it to be easily extended to tell jokes from other joke APIs in the future.
