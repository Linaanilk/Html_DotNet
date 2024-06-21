namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Order order1 = new Order();
            //subscribe to event
            order1.OnCreated += Email.Send;
            order1.OnCreated += Sms.Send;
            order1.Create("lina@gmail.com",9896785213);
        }
    }
}
