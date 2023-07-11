namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool endApp = false;
            Console.WriteLine("***Calculator for Areas****");
            Console.WriteLine();

            while (!endApp)
            {
                string l = "";
                string b = "";
                string r = "";
                string s = "";
                double result = 0;

                Console.WriteLine("Choose the option from the below list to do the operation");
                Console.WriteLine("1- Area of Rectangle");
                Console.WriteLine("2- Area of Square");
                Console.WriteLine("3- Area of Circle");
                Console.WriteLine("Choose your option");
                string opt = Console.ReadLine();
                int op = 0;
                while (!int.TryParse(opt, out op))
                {
                    Console.WriteLine("This is not a valid input, Please enter the numeric value. ");
                    opt = Console.ReadLine();
                }
                try
                {
                    switch (op)
                    {
                        case 1:
                            {
                                Console.Write("Enter the length: ");
                                l = Console.ReadLine();

                                double length = 0;
                                while (!double.TryParse(l, out length))
                                {
                                    Console.WriteLine("This is not a valid input, Please enter the numeric value. ");
                                    l = Console.ReadLine();
                                }

                                Console.Write("Enter the breadth: ");
                                b = Console.ReadLine();

                                double breadth = 0;
                                while (!double.TryParse(b, out breadth))
                                {
                                    Console.WriteLine("This is not a valid input, Please enter the numeric value. ");
                                    b = Console.ReadLine();
                                }


                                result = AreaMethod.areaOfRectangle(length, breadth);
                                if (double.IsNaN(result))
                                {
                                    Console.WriteLine("Something goes wrong!, Please try once again");
                                }
                                else
                                {
                                    Console.WriteLine(result);
                                }
                            }
                            break;
                        case 2:
                            {
                                Console.Write("Enter the side of square: ");
                                s = Console.ReadLine();
                                double side = 0;
                                while (!double.TryParse(s, out side))
                                {
                                    Console.WriteLine("This is not a valid input, Please enter the numeric value. ");
                                    s = Console.ReadLine();
                                }


                                result = AreaMethod.areaOfSquare(side);
                                if (double.IsNaN(result))

                                    Console.WriteLine("Something goes wrong!, Please try once again");
                                else
                                    Console.WriteLine(result);

                            }
                            break;
                        case 3:
                            {


                                Console.Write("Enter the radius: ");
                                r = Console.ReadLine();

                                double radius = 0;
                                while (!double.TryParse(r, out radius))
                                {
                                    Console.WriteLine("This is not a valid input, Please enter the numeric value. ");
                                    r = Console.ReadLine();
                                }


                                result = AreaMethod.areaOfCircle(radius);
                                if (double.IsNaN(result))
                                {
                                    Console.WriteLine("Something goes wrong!, Please try once again");
                                }
                                else
                                {
                                    Console.WriteLine(result);
                                }

                            }
                            break;

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