namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days the book is overdue: ");
            int daysOverdue = int.Parse(Console.ReadLine());
            double fine = CalculateFine(daysOverdue);

            Console.WriteLine($"The fine amount is: Rs. {fine}");

            if (daysOverdue > 30)
            {
                Console.WriteLine("Library membership has been cancelled.");
            }
        }

        static double CalculateFine(int daysOverdue)
        {
            if (daysOverdue <= 7)
            {
                return 0;
            }
            else if (daysOverdue > 7 && daysOverdue <= 14)
            {
                return 50 * (daysOverdue - 7);
            }
            else if (daysOverdue >= 15 && daysOverdue <= 30)
            {
                return (50 * 7) + (100 * (daysOverdue - 14));
            }
            else
            {
                return (50 * 7) + (100 * 16) + (200 * (daysOverdue - 30));
            }
        }
    }
}