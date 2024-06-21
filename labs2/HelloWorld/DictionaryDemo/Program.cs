namespace DictionaryDemo
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, double>> currency = new Dictionary<string, Dictionary<string, double>>();
        static void Main(string[] args)
        {
            AddCurrencyRate("USD", "INR", 83.34);
            AddCurrencyRate("INR", "USD", .012);
            AddCurrencyRate("SGC", "INR", 62.23);
            AddCurrencyRate("INR", "SGD", 0.16);
            AddCurrencyRate("INR", "GBP", .0095);
            AddCurrencyRate("GBP", "INR", 105.08);
            Console.WriteLine("Enter the source Currency");
            string source = Console.ReadLine().ToUpper();
            if (string.IsNullOrEmpty(source) || !currency.ContainsKey(source))
            {
                Console.WriteLine("Not a valid Currency");
                return;
            }
            Console.WriteLine("Enter the source Currency");
            string target = Console.ReadLine().ToUpper();
            if (string.IsNullOrEmpty(target) || !currency[source].ContainsKey(target))
            {
                Console.WriteLine("Not a valid Currency");
            }
            Console.WriteLine("Enter the Amount");
            string input = Console.ReadLine().ToUpper();
            if (!int.TryParse(input, out int value) || input == null)
            {
                Console.WriteLine("Not a valid Currency");
                return;
            }
            Console.WriteLine($"Convert amount of {value} {source} to {target} is {convert(value, source, target)}");
        }
        static void AddCurrencyRate(string source, string target, double rate)
        {
            if (!currency.ContainsKey(source))
            {
                currency[source] = new Dictionary<string, double>();
            }
            currency[source][target] = rate;
        }
        static double convert(double amount, string source, string target)
        {
            if (currency.ContainsKey(source) && currency[source].ContainsKey(target))
            {
                double ExchnageRate = amount * currency[source][target];
                return ExchnageRate;
            }
            else
            {
                Console.WriteLine("Currency Exchage not possible");
                return 0;
            }
        }

    }
}