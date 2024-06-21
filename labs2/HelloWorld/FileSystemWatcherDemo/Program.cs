using System.Reflection.Emit;

namespace FileSystemWatcherDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           FileSystemWatcher watcher = new FileSystemWatcher(@"C:\HTML\labs2\demos");
            watcher.EnableRaisingEvents = true;
            watcher.Created += Watcher_Change;
            watcher.Deleted += Watcher_Change;
            watcher.Changed += Watcher_Change;
            Console.ReadLine();
        }

        private static void Watcher_Change(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Name:{e.Name}, change:{e.ChangeType}");
        }
    }
}
