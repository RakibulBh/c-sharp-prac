namespace first_program;

class Program
{
    static void Main(string[] args)
    {
        while (true) {
            Console.Write("Enter first number: ");
            string num1 = Console.ReadLine() ?? "0";
            Console.Write("Enter second number: ");
            string num2 = Console.ReadLine() ?? "0";

            Console.WriteLine(Int32.Parse(num1) + Int32.Parse(num2));
        }
    }
}
