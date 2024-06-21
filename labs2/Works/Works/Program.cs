namespace Works
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] arr=new int[14];
            int i;
            Console.WriteLine("enter ten numbers");
            for ( i = 0; i<=10; i++)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int id))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                arr[i] = id;
                
                
            }
            Console.WriteLine("Even Numbers");
            for ( i = 0; i<=10;i++) 
            {
               
                if (arr[i]%2==0)
                {
                    Console.WriteLine( arr[i]);
                }
                
            }
            Console.WriteLine("Odd Numbers");
            for (i = 0; i <= 10; i++)
            {
               
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
               
            }

        }
    }
}
