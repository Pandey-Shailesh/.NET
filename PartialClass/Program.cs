using PartialClassLibrary;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales();
            sales.TotalNoOfEmployees = 10;
            sales.TotalExpenditute();
            Console.ReadKey();
        }
    }
}