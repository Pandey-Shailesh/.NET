namespace CalculatorApp
{
    class Calculator
    {
        public static double doCalculation(double num1, double num2, string op)
        {
            double result = double.NaN; // NaN means not a number

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;

                case "s":
                    result = num1 - num2;
                    break;

                case "m":

                    result = num1 * num2;
                    break;

                case "d":
                    //while (num2 == 0)
                    //{
                    //    Console.WriteLine("Please enter the non-zero number");
                    //    num2 = Convert.ToDouble(Console.ReadLine());
                    //}
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
