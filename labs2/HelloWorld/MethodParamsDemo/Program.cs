namespace MethodParamsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 10;
            obj = "abc";

            var val = 12;
            val = "abc";

            dynamic obj2 = 10;
            obj2 = "abc";


            int number=20;
            Method1(ref number);
            Console.WriteLine(number);
            int num2;
            Method3(1, 2, 3, 4, 5, 6, 7, 8);
            Method4(new int[] { 1, 2, 3 } );
        }
        static void Method1(ref int num)
        {
            num = num + 10;
           // return num;
        }

        static void Method2(out int num)
        {
            num = 10;
        }

        static void Method3(params int[] numbers) 
        {
        
        }
        static void Method4(int[] numbers)
        {

        }
    }
}
