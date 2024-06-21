namespace BuiltInDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Func<double, double,double> add= (a,b) => a + b;
            double sum=add(12.4, 2.4);
            Console.WriteLine(sum);
            
        }
    }
}
