namespace ExtensionMethodsExample
{
    // Assume this class is already created by someone else or this an old class
    public class AreaCalculation
    {
        double len, width;
        public AreaCalculation()
        {
            Console.WriteLine("Enter the length of Rectangle: ");
            len = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of Rectangle: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public void AreaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle = " + len * width + " Square Unit");
        }

        public void AreaOfCircle(double radius)
        {
            Console.WriteLine("Area of Circle = " + 3.14 * radius * radius + " Square Unit");
        }
    }
}
