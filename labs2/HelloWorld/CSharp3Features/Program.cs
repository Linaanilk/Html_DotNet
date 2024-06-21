namespace CSharp3Features
{
    internal class Program
    {
        //var a = 10;
        static void Main(string[] args)
        {
            //var i = 10;
            //i = "abc";
            //var message;

            var product = new
            {
                Id = 10,
                Name = "Earphones",
                price=10
            };

            string number = "123";
            int num = number.ToNumber();

           Customer customer1 = new Customer(1);
            
                //customer1.CustomerId = 1;
                customer1.Name = "John Don";
                customer1.City = "New Jersey";


            Customer customer2 = new Customer(2)
            {
               // CustomerId = 2,
                Name = "Jaya",
                City = "Ernakulam",
            };
            List<Customer> customerlist = new List<Customer>
            {
                customer1,
                customer2,
                new Customer(3)
                {
                    Name="Tycon",
                    City="Westeros"
                }
            };
        }
        //static Method1(var num)
        //{

        //}
    }
}
