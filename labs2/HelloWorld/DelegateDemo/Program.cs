namespace DelegateDemo
{
    //1
    public delegate void MathDelegate(int num1,int num2);                                
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            MathDelegate mathDe1 = Add;
            mathDe1 += Sub;
            mathDe1 += Mul;
            mathDe1 += Div;
         
            MathDelegate mathDe2 = new MathDelegate(mathDe1);

            //4
            mathDe1(2, 3);
        }
        //2
        public static void Add(int num1,int num2)
        {
            Console.WriteLine("sum");
            Console.WriteLine(num1 + num2);
            
        }
        public static void Sub(int num1, int num2)
        {
            Console.WriteLine("Difference");
            Console.WriteLine(num1 - num2);
        }
        public static void Mul(int num1, int num2)
        {
            Console.WriteLine("Multiplication");
            Console.WriteLine(num1 * num2);
        }
        public static void Div(int num1, int num2)
        {
            Console.WriteLine("Division");
            Console.WriteLine(num1 / num2);
        }
    }
}
