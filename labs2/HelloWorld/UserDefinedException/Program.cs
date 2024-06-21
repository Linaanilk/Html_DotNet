namespace UserDefinedException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string number = "abc";
            //    int num = Convert.ToInt32(number);
            //} 
            //catch (FormatException e )
            //{
            //    Console.WriteLine(e.Message);
            //}
            try
            {
                string number = "abc";
                int num = Convert.ToInt32(number);
            }
            catch (FormatException ex)
            {
                throw new InvalidNumberException(ex.Message);
            }
        }
    }
}
