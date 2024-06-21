using AddNumbersConsole;

namespace AddNumbersLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "123";
            int num=Convert.ToInt32(number);

            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();
            // int num1=int.Parse(input1);

            if (!int.TryParse(input1, out int num1))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter second number");
            input1 = Console.ReadLine();
            //int num2=int.Parse(input1); 

            if (!int.TryParse(input1, out int num2))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int sum = NumbersClass.Add(num1, num2);
            Console.WriteLine(" sum = " + sum);
        }
    }
}
