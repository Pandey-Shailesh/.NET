namespace TypeParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 120;
            int num2 = num1;
            Console.WriteLine("Value of num2 = " + num2);
            num2 = 150;
            Console.WriteLine("Value of num1 = " + num1);
            Console.WriteLine("Value of num2 = " + num2);
            Console.ReadKey();
        }
    }
}