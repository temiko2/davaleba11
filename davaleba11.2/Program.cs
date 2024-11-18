

namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result1 = MathHelper.Add(2, 7);
            var result2 = MathHelper.Subtract(6, 5);
            var result3 = MathHelper.Multiply(1, 8);
            var result4 = MathHelper.Divide(37, 77);
            Console.WriteLine($"Add(4 + 7) = {result1}");
            Console.WriteLine($"Subtract(6 - 2) = {result2}");
            Console.WriteLine($"Multiply(5 * 9) = {result3}");
            Console.WriteLine($"Divide(3:6) = {result4}");  

        }
    }
}
