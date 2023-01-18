using ConversorMoedasAPI.Models;

class Program
{
    static public void Main()
    {
        var c = new CurrencyConverter
        {
            From = "USD",
            To = "EUR"
        };

        Console.WriteLine(" ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"{c.From}  => {c.ConverterAsync()} {c.To}");
    }
}