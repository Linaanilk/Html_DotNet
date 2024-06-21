namespace Fibanocci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1=0, t2=1,t3=0,i;
            Console.WriteLine("Enter a digit");
            string input=Console.ReadLine();
            if(!int.TryParse(input, out int result)) 
            {
                Console.WriteLine("invalid input");
                return; 
            }
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            for ( i = 0; i < result-2; i++)
            {

                t3 = t1 + t2;
                t1 = t2;
                
                t2 = t3;
               

               // Console.WriteLine(t2);
                Console.WriteLine(t3);


            }
        }
    }
}
