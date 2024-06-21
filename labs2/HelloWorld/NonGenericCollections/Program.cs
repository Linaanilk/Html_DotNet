using System.Collections;

namespace NonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arraylist
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(true);
            list.Add("abc");

            //stack LIFO, push,pop
            Stack items= new Stack();
            items.Push(1);
            items.Push(2);
            items.Push(3);
            items.Push(4);
            Console.WriteLine($"stack count:{items.Count}");
           // Console.WriteLine(items.cap);

            var value= items.Pop();

            Queue movies= new Queue();
            movies.Enqueue("RDX");
            movies.Enqueue("kilukkam");
            movies.Enqueue("Honey Bee");
            movies.Enqueue("RDX");
            Console.WriteLine($"Queue count:{movies.Count}");
            movies.Dequeue();
            Console.WriteLine($"Queue count:{movies.Count}");

        }
    }
}
