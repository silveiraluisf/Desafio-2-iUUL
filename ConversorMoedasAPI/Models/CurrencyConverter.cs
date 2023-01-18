using System.Net.Http.Json;
using System.Net;
using System.Text.Json.Serialization;
using System;
using System.Text.Json;

namespace ConversorMoedasAPI.Models
{
    public class CurrencyConverter
    {
        [JsonPropertyName("from")]
        public string? From { get; set; }

        [JsonPropertyName("to")]
        public string? To { get; set; }

        [JsonPropertyName("amount")]
        public int? Amount { get; set; }



        static readonly HttpClient client = new HttpClient();
        public async Task<double> ConverterAsync()
        {
            try
            {
                using HttpResponseMessage response = await client.GetAsync($"https://api.exchangerate.host/convert?from={From}&to={To}&amount={Amount}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                ConvertOutput objResponse = JsonSerializer.Deserialize<ConvertOutput>(responseBody);

                double output = Math.Round(Convert.ToDouble(objResponse.Output), 2); ;

                return output;
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao acessar a API!");
                return -1;
            }
        }
    }
}