using System.Collections;

namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hashtable users = new Hashtable();
            string input;
            for (int index = 0; index < 3; index++) 
            {
                Console.WriteLine("Enter userId");
                input= Console.ReadLine();

                if(!int.TryParse(input,out int userId))
                {
                    Console.WriteLine("Invalid Input");
                    index--;
                    continue;
                }
                Console.WriteLine("Enter username");
                input = Console.ReadLine();
                if(string.IsNullOrEmpty(input)) 
                {
                    Console.WriteLine("Invalid Input");
                    index--;
                    continue;
                }
                //users.Add(userId,input);
                users[userId] = input;

              
            }
            Console.WriteLine("User Information");
            foreach (DictionaryEntry element in users)
            {
                Console.WriteLine($"{element.Key}:\t{element.Value}");
            }
            Console.WriteLine("Enter User Id");
            input=Console.ReadLine();
            if(!int.TryParse(input, out int userId1))
            {

                Console.WriteLine("Invalid input");
                return;
            }
            if(users.ContainsKey(userId1)) 
            {
            Console.WriteLine($"User found, name is{users[userId1]}");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }
    }
}
