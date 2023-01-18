using System.Net;
using System.Text.Json;

namespace ConversorMoedasAPI.Models
{
    public class CurrencyConverter
    {
        public string? From { get; set; }

        public string? To { get; set; }

        public int? Amount { get; set; }
    }
}