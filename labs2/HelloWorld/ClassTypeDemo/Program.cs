namespace ClassTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Class1 instance = new Class1();
            //instance.Name = "Test";
            //Class1.M2();

            string name = null;
            int? num= null;

            int i=num==null?0: num.Value;
            int j = num ?? 0;
            int k = num.HasValue ? num.Value : 0;
        }
    }

  static class Class1

    {
        //int id;
        //public string Name { get; set; }
        //public void M1()
        //{

        //}
        public static void M2()
        { 
        }
    }
}
