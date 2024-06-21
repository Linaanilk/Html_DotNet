namespace FileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FileInfo fileInfo = new FileInfo(@"C:\HTML\labs2\HelloWorld\file.txt");
            DirectoryInfo directory = new DirectoryInfo("C:\\HTML\\labs2\\Demos");
          // var directoryDemos= directory.CreateSubdirectory("demos");

            if(!directory.Exists)
            {
                directory.Create();
            }

            foreach(var file in directory.GetFiles())
            {
                Console.WriteLine($"Name: {file.Name}");
                Console.WriteLine($"Size: {(float)(file.Length)/1024}KB");
                Console.WriteLine($"Last Updated: {file.LastWriteTime}");
               
            }
            DriveInfo[] drives=DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives) 
            {
                Console.WriteLine($"Drive: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                Console.WriteLine($"Free Space:{(drive.TotalFreeSpace)/1024/1024/1024}GB");
            }

            //else
            //{
            //    var dir = directory.GetFiles("demos");
            //    Console.WriteLine(dir);
            //}
            //


        }
    }
}
