using ConversorMoedasAPI.Models;

namespace ConversorMoedasApiRest.Views
{
    public class IMainMenu
    {
        private string _inputFrom;
        private string _inputTo;
        private string _inputAmount;
        public string InputFrom
        {
            get { return _inputFrom; }
            set { _inputFrom = value; }
        }
        public string InputTo
        {
            get { return _inputTo; }
            set { _inputTo = value; }
        }
        public string InputAmount
        {
            get { return _inputAmount; }
            set { _inputAmount = value;}
        }
        public void Title()
        {
            Console.WriteLine("---- Conversor de Moedas com acesso a API REST ----\n");
        }
        public void GetData()
        {
            Console.WriteLine("Insira a sigla da moeda origem para conversão (USD, BRL, EUR, etc): ");
            this._inputFrom = Console.ReadLine();
            Console.WriteLine("Insira a sigla da moeda destino para conversão (USD, BRL, EUR, etc): ");
            this._inputTo = Console.ReadLine();
            Console.WriteLine("Insira a quantidade: ");
            this._inputAmount = Console.ReadLine();
        }
        public void ShowData(Root root)
        {
            Console.WriteLine($"Moeda origem: {root.query.from}");
            Console.WriteLine($"Moeda destino: {root.query.to}");
            Console.WriteLine($"Valor: {root.query.amount} \n");

            Console.WriteLine($"{root.query.from} {root.query.amount} => {root.query.to} {root.result.ToString("F")} \n");
            Console.WriteLine($"Taxa: {root.info.rate.ToString("F6")} \n");
        }

        public void ErrorMessage()
        {
            Console.WriteLine("Favor insira uma opção válida. \n");
        }
    }
}
