using ConversorMoedasAPI.Models;
using ConversorMoedasApiRest.Views;
using System.Text.Json;


namespace ConversorMoedasApiRest.Controllers
{
    public class ConvertRequestController
    {
        static readonly HttpClient client = new HttpClient();

        public async Task GetCurrencyConverter()
        {
            IMainMenu menu = new();
            menu.GetData();
            
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync($"https://api.exchangerate.host/convert?from={menu.InputFrom}&to={menu.InputTo}&amount={menu.InputAmount}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                string json = responseBody.ToString();

                Root r = JsonSerializer.Deserialize<Root>(json);

                menu.ShowData(r);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
