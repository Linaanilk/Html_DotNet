namespace OptionalAndNamedParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddBook(isbn: "abc", price: 100, title: "abc", author: "xyz");
            AddBook("abc", "jhsdjf", "bhu");
            AddBook("abc", "jhsdjf", "bhu",200);
            AddBook("abc", "bhu");
        }

        static bool AddBook(string title, string author, string isbn = "123", decimal price =100)
        {
            return true;
        }
    }
}
