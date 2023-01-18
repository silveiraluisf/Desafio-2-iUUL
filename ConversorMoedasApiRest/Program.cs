using ConversorMoedasAPI.Models;
using ConversorMoedasApiRest.Controllers;
using ConversorMoedasApiRest.Views;
using System.Text.Json;

class Program
{
    public static async Task Main()
    {
        IMainMenu menu = new();
        ConvertRequestController crc = new ConvertRequestController();
        menu.Title();
        await crc.GetCurrencyConverter();
        await Main();
    }
}
