

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> instance=new GenericClass<int>();
            instance.Add(1);

            GenericClass<string> instance2=new GenericClass<string>();
            instance2.Add("abc");

            int i = 12;
            object obj = i;//boxing
            int j=(int)obj;

            int[] arr = { 1, 2 };
            object[] arr1 = { 1, true, "abc" };

            for (int index = 0; index < arr1.Length; index++)
            {
                object obj1 = arr1[index];
            }
        }
    }
}
