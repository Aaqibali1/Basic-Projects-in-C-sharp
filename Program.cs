internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your another Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(num1 + num2);
        Console.WriteLine(num1 - num2);
        Console.WriteLine(num1 / num2);
        Console.WriteLine(num1 % num2);

    }
}