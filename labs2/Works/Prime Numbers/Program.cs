namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, i;

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("error");
                return;
            }
            for (i = 2; i < result / 2; i++)
            {
                if (result % i == 0)
                {
                    flag++;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("Non prime");
            }
        }
    }
}
