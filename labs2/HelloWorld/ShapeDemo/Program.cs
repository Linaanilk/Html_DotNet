namespace ShapeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1.circle  2.Rectangle 3.Triangle 4.Square 5.Trapezium 6.Exit");
                Console.WriteLine("select shape");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        HandleCircle();
                        break;

                    case 2:
                        HandleRectangle();
                        break;

                    case 3:
                        HandleTriangle();
                        break;

                    case 4:
                       HandleSquare();
                        break;

                    case 5:
                        HandleTrapezium();
                        break;
                     case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }

        }

        static void HandleCircle()
        {

            Console.WriteLine("Enter radius");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double radius))
            {
                Console.WriteLine("Invalid radius");
                return;
            }
            Console.WriteLine(input);


            Circle circle1 = new Circle(radius);
            double area = circle1.Area();
            Console.WriteLine($"Area of circle: {area}");
        }

        static void HandleRectangle()
        {

            Console.WriteLine("Enter length");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double length))
            {
                Console.WriteLine("Invalid radius");
                return;
            }
            Console.WriteLine(input);
            Console.WriteLine("Enter breadth");
            string input1 = Console.ReadLine();
            if (!double.TryParse(input1, out double breadth))
            {
                Console.WriteLine("Invalid radius");
                return;
            }
            Console.WriteLine(input1);


            Rectangle rect1 = new Rectangle(length, breadth);
            double area = rect1.Area();
            Console.WriteLine($"Area of Rectangle: {area}");
        }


        static void HandleTriangle()
        {

            Console.WriteLine("Enter breadth");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double breadth))
            {
                Console.WriteLine("Invalid length");
                return;
            }
            Console.WriteLine(input);
            Console.WriteLine("Enter height");
            string input1 = Console.ReadLine();
            if (!double.TryParse(input1, out double height))
            {
                Console.WriteLine("Invalid height");
                return;
            }
            Console.WriteLine(input1);


            Triangle tri1 = new Triangle(breadth, height);
            double area = tri1.Area();
            Console.WriteLine($"Area of Triangle: {area}");
        }
        static void HandleSquare()
        {

            Console.WriteLine("Enter side");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double length))
            {
                Console.WriteLine("Invalid radius");
                return;
            }
            Console.WriteLine(input);
          


            Rectangle rect1 = new Rectangle(length, length);
            double area = rect1.Area();
            
            Console.WriteLine($"Area of Square: {area}");
        }

        static void HandleTrapezium()
        {

            Console.WriteLine("Enter length");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double length))
            {
                Console.WriteLine("Invalid radius");
                return;
            }
            Console.WriteLine(input);
            Console.WriteLine("Enter breadth");
            string input1 = Console.ReadLine();
            if (!double.TryParse(input1, out double breadth))
            {
                Console.WriteLine("Invalid radius");
                return;
            }
            Console.WriteLine(input1);
          
            Console.WriteLine("Enter height");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double height))
            {
                Console.WriteLine("Invalid radius");
                return;
            }
            Console.WriteLine(input2);


            Trapezium trap1 = new Trapezium(height,length, breadth);
            double area = trap1.Area();
            Console.WriteLine($"Area of Rectangle: {area}");
        }

    }
}
