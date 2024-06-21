namespace TaskParallelismAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task<int> task1 = Task.Run(() => DoAsyncWork("Task1"));
            Task<int> task2 = Task.Run(() => DoAsyncWork("Task2"));
            Task<int> task3 = Task.Run(() => DoAsyncWork("Task3"));

            int[] results=await Task.WhenAll(task1, task2, task3);
            Console.WriteLine($"Results: {string.Join(",",results)}");

        }

        static async Task<int> DoAsyncWork(string taskName)
        {
            Console.WriteLine($"working on {taskName} asynchronously on thread {Task.CurrentId}");
            await Task.Delay(2000);
            return taskName.Length;
        }
    }
}
