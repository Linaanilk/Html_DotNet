namespace ComplexNumbers
{
   using System;

public class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex Add(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the real part of the first complex number:");
        double real1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the imaginary part of the first complex number:");
        double imag1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the real part of the second complex number:");
        double real2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the imaginary part of the second complex number:");
        double imag2 = Convert.ToDouble(Console.ReadLine());

        Complex num1 = new Complex(real1, imag1);
        Complex num2 = new Complex(real2, imag2);

        Complex sum = Complex.Add(num1, num2);

        Console.WriteLine($"Sum: {sum}");
    }
}

}
