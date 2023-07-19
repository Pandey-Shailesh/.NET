namespace ExtensionMethodsExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                10, 20, 30, 40, 50, 60,
            };

            var List1 = list.Where(x => x > 40).ToList();
            foreach (var item in List1)
            {
                Console.WriteLine(item);
            }

            AreaCalculation ac = new AreaCalculation(); // constructor will automatically invoked 
            ac.Area1(); // extension method is going to call as non-static method
            ac.Area2(5);
            Console.ReadKey();
        }
    }
}