using CalculatorLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        private static bool exit=false;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no.");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double id) )
            {
                Console.WriteLine("Invalid input");
                return;
            }
            calculator calc = new calculator();
            Console.WriteLine("Enter second no.");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double id2))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            do
            {
                Console.WriteLine("Choose any operation 1.Addition  2.Subtraction 3.Multiplication 4.Division 5.Exit");
                string input3 = Console.ReadLine();
                if (!int.TryParse(input3, out int id3))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                switch (id3)
                {

                    case 1:
                        Console.WriteLine($"Result: {calculator.Add(id, id2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {calculator.Subtract(id, id2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {calculator.Multiply(id, id2)}");
                        break;

                    case 4:
                        Console.WriteLine($"Result: {calculator.Divide(id, id2)}");
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid operation choice");
                        break;

                }
            } while (!exit);
            }
        }
    }

