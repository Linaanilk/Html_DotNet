namespace VarianceDemo
{
    public delegate Small Delegate1(Big big);
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegate1 del1 = new Delegate1(Method1);
            Delegate1 del2 = Method2;

           Small s= del1(new Big());
            Small s1 = del2(new Big());

            Delegate1 del3 = Method3;
            //Small s3 = del3(new Small());
            Small s4=del3(new Big());


        }
        public static Big Method1(Big big)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        public static Small Method2(Big big)
        {
            Console.WriteLine("Method2");
            return new Small();
        }
        public static Small Method3(Small small)
        {
            Console.WriteLine("Method 3");
            return new Small();
        }
    }
    public class  Small
    {

    }
    public class Big:Small
    {

    }
    public class Bigger:Big
    {

    }

}
