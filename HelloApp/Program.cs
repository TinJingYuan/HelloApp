namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a, b;
            string[] input = Console.ReadLine().Split();
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
        }
    }
}