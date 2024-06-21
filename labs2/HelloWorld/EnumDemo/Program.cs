namespace EnumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers=new int[4];
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index]);
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            WeekDays day = WeekDays.Wednesday;

            switch (day)
            {
                case WeekDays.Sunday:
                    break;
                case WeekDays.Monday:
                    break;
                case WeekDays.Tuesday:
                    break;
                case WeekDays.Wednesday:
                    break;
                case WeekDays.Thursday:
                    break;
                case WeekDays.Friday:
                    break;
                case WeekDays.Saturday:
                    break;
                default:
                    break;
            }

        }
    }
}
