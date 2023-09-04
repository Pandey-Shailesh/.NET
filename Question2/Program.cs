namespace Question2
{
     public class Program
    {
        public static void Main()
        {
            IShape rectangle = new Rectangle(10, 5);
            IShape circle = new Circle(7);
            IShape triangle = new Triangle(10, 5);

            Console.WriteLine($"Area of rectangle: {rectangle.CalculateArea()}");
            Console.WriteLine($"Area of circle: {circle.CalculateArea()}");
            Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");
        }
    }
}