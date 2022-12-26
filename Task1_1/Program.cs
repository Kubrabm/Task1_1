namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); if (input.Length < 2 || input.Length > 2)
            {
                Console.WriteLine("Eded iki reqemli deyil");
                return;
            }

            int number = int.Parse(input);
            int lastDigit = number % 10;
            number /= 10;

            Console.WriteLine($"{number} {lastDigit}");
        }
    }
}