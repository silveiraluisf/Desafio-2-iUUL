using System.Text.Json.Serialization;

namespace ConversorMoedasAPI.Models
{
    public class Info
    {
        [JsonPropertyName("rate")]
        public double rate { get; set; }
    }

    public class Motd
    {
        [JsonPropertyName("msg")]
        public string? msg { get; set; }
        [JsonPropertyName("url")]
        public string? url { get; set; }
    }

    public class Query
    {
        [JsonPropertyName("from")]
        public string? from { get; set; }

        [JsonPropertyName("to")]
        public string? to { get; set; }

        [JsonPropertyName("amount")]
        public int amount { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("motd")]
        public Motd? motd { get; set; }

        [JsonPropertyName("sucess")]
        public bool success { get; set; }

        [JsonPropertyName("query")]
        public Query? query { get; set; }

        [JsonPropertyName("info")]
        public Info? info { get; set; }

        [JsonPropertyName("historical")]
        public bool historical { get; set; }

        [JsonPropertyName("date")]
        public string? date { get; set; }

        [JsonPropertyName("result")]
        public double result { get; set; }
    }
}
