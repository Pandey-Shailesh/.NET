namespace ExtensionMethodsExample
{
    public static class Calculation
    {
        public static void Area1(this AreaCalculation Obj)
        {
            double len = 10, width = 20;
            Console.WriteLine("Perimeter = " + 2 * (len + width));
            Obj.AreaOfRectangle();
        }

        public static void Area2(this AreaCalculation Obj, double r)
        {

            Console.WriteLine("This is Area2 method of the Calculation Class");
            Obj.AreaOfCircle(5);
        }
    }

}
