namespace MarksAndPercentage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Subjects marks out off 100");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Subjects marks out off 100");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Subjects marks out off 100");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth Subjects marks out off 100");
            int m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fifth Subjects marks out off 100");
            int m5 = Convert.ToInt32(Console.ReadLine());

            
            int percentage;
            int sum = m1+ m2 + m3 + m4 + m5;
            int average = sum% 500;
            percentage = average*  100;
            Console.WriteLine(average);
            Console.WriteLine("Total marks is :"+sum);
            Console.WriteLine("Percentage is:"+percentage);
        }
    }
}