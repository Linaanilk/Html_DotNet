namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> recipes = new List<string>();

            Console.WriteLine(recipes.Capacity);
            recipes.Add("Beef biryani");
            recipes.Add("Shawarma");
            recipes.Add("Honey glazed chicken");
            recipes.Add("chilly fish");
            recipes.Add("Bangkok beef");
            recipes.Add("Honey glazed chicken");
            recipes.Add("chilly fish");
            recipes.Add("Bangkok beef");
            recipes.Add("Bangkok beef");
            recipes.Clear();
           // Console.WriteLine(recipes.Count);
            Console.WriteLine(recipes.Capacity);

            List<int> numbers= new List<int>
            {
                1,
                2, 

            };

        }
    }
}
