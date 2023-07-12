namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            // double num1 = 0; double num2 = 0;

            bool endApp = false;
            Console.WriteLine("********Calculator App in C#.Net*********");
            Console.WriteLine();

            while (!endApp)
            {
                string num1 = "";
                string num2 = "";
                double result = 0;

                // prompt the user to enter the value
                Console.Write("Enter the first number: ");
                num1 = Console.ReadLine();

                double correctInput1 = 0;
                while (!double.TryParse(num1, out correctInput1))
                {
                    Console.WriteLine("This is not a valid input, Please enter the numeric value. ");
                    num1 = Console.ReadLine();
                }

                Console.Write("Enter the second number: ");
                num2 = Console.ReadLine();

                double correctInput2 = 0;
                while (!double.TryParse(num2, out correctInput2))
                {
                    Console.WriteLine("This is not a valid input, Please enter the numeric value. ");
                    num2 = Console.ReadLine();
                }

                Console.WriteLine("Choose the option from the below list to do the operation");
                Console.WriteLine("\ta-Addition");
                Console.WriteLine("\ts-Substraction");
                Console.WriteLine("\tm-Multiplication");
                Console.WriteLine("\td-Division");
                Console.WriteLine("Choose your option");
                string op = Console.ReadLine();

                try
                {
                    result = Calculator.doCalculation(correctInput1, correctInput2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Something goes wrong!, Please try once again");
                    }
                    else
                    {
                        Console.WriteLine("Result = {0:0.##}\n", result);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("An exception generated to do the maths operation! Kindly verify at your end");
                }

                Console.Write("Press 'n' to close the Calculator App! or press any other key to continue");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }



            }
            return;
        }
    }
}