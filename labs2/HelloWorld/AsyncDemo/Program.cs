namespace AsyncDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await M1();
            await M2();
            var result=await M3();
            var result2=await M4();
        }
        static async Task M1()
        {
            await Console.Out.WriteLineAsync(nameof(M1));
        }
        static async Task M2() 
        {
            await Console.Out.WriteLineAsync(nameof(M2));
        }
        static async ValueTask<DateTime> M3()
        {
            await Console.Out.WriteLineAsync(nameof(M3));
            return DateTime.Today;
        }
        static async Task<string> M4()
        {
            await Console.Out.WriteLineAsync(nameof(M4));
            return "hello";
        }
    }
}
