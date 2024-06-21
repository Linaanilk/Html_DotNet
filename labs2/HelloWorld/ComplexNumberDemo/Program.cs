namespace ComplexNumberDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(10, 3);
            ComplexNumber c2 = new ComplexNumber(2, 11);

            ComplexNumber c3=c1 + c2;
            Console.WriteLine(c3);

        }
    }
}
