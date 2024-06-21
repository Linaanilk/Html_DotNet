namespace FileStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\HTML\\labs2\\demos\\file5.txt";
            //FileStream stream=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(stream);
            //writer.WriteLine("Hello World");
            //writer.WriteLine("Welcome to Speridian");
            //writer.Close();
            //stream.Close();

            try
            {
                using (FileStream stream1=new FileStream(path,FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter writer1 = new StreamWriter(stream1))
                    {
                        writer1.WriteLine("Hello World");

                        writer1.WriteLine("Welcome to Speridian");
                    }
                }

            }
            catch (IOException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
              using(FileStream stream=new FileStream(path, FileMode.Open, FileAccess.Read))
               {
                    StreamReader reader=new StreamReader(stream);
                  /// reader.ReadLine();
                  string line;
                  while((line=reader.ReadLine()) != null) 
                    {
                        Console.WriteLine(line);
                    }
              }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }





            //FileStream stream1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            //StreamWriter reader = new StreamWriter(stream1);
            //writer.WriteLine("Hello World");
            //writer.WriteLine("Welcome to Speridian");
            //writer.Close();
            //stream.Close();


        }
    }
}
