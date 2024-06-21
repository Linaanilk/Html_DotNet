namespace QueryExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1,2,3,4,5,6,7};
            //1 foreach

            //2 lambda expression
           List<int> evenNumbers= numbers.FindAll(n=>n%2==0);
            //3 Query expression
            //3.1 Query syntax
            var evenNum=from n in numbers
                        where n%2==0
                        select n;

            //3.2 Method/lambda syntax
            var evenNum2=numbers.Where(n=>n%2==0);

            foreach (var num in evenNum2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
