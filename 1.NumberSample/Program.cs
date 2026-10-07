class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        int sum = a + b;
        Console.WriteLine($"The sum of {a} and {b} is: {sum}");


        int product = a * b;
        Console.WriteLine($"The product of {a} and {b} is: {product}");

        int modulus = b % a;
        Console.WriteLine($"The modulus of {b} and {a} is: {modulus}");

        int difference = b - a;
        Console.WriteLine($"The difference between {b} and {a} is: {difference}");

        int quotient = b / a;
        Console.WriteLine($"The quotient of {b} divided by {a} is: {quotient}");

        
    }
}
