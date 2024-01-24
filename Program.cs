namespace Largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is the greatest ");
                Console.WriteLine("num1 is the greatest ");
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " is the greatest ");
                Console.WriteLine("num2 is the greatest ");
            }
            else /*(num1 == num2)*/{
                Console.WriteLine(num1 + " equal to " + num2);
                Console.WriteLine("num1 and num2 are equal");
            }
        }
    }
}
