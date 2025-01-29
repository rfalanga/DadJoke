// write a program that will tell a dad joke using the icanhazdadjoke API (https://icanhazdadjoke.com/api) and the HttpClient class.
// The program should make a GET request to the API and then print the joke to the console.
using System.Text.Json.Serialization;

public class JokeResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("joke")]
    public string Joke { get; set; } = "";

    [JsonPropertyName("status")]
    public int Status { get; set; }
}
// The program should be written in a way that allows it to be easily extended to tell jokes from other joke APIs in the future.
