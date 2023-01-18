using ConversorMoedasAPI.Models;
using System.Text.Json;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {
            using HttpResponseMessage response = await client.GetAsync("https://api.exchangerate.host/convert?from=BRL&to=USD&amount=300");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            string json = responseBody.ToString();

            Root r = JsonSerializer.Deserialize<Root>(json);

            Console.WriteLine($"Resultado = {r.result}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }
    }
}
