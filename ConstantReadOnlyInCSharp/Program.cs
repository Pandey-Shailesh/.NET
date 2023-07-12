namespace ConstantReadOnlyInCSharp
{
    class Test
    {
        public const int NoOfMonthsInYear = 12;
    }
    class Test2
    {
        public readonly int NoOfDaysInWeek = 7;

    }

    class Delhi
    {
        public string redFort = "Delhi.RedFort";
        public string tajMahal = "Agra.TajMahal";
    }
    class India
    {
        public Delhi dl = new Delhi();
    }

    class DefaultValue
    {
        public void Display(int n = 25)
        {
            Console.WriteLine("Value of n is: " + n);
        }
        public void print(int x, int y)
        {
            Console.WriteLine("Value of x: " + x);
            Console.WriteLine("Value of y: " + y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test2 t = new Test2();
            Console.WriteLine(Test.NoOfMonthsInYear);
            Console.WriteLine(t.NoOfDaysInWeek);

            India ind = new India();
            Console.WriteLine(ind.dl.redFort);

            DefaultValue dv = new DefaultValue();
            dv.Display(100);// print 100 on the console
            dv.Display(200); // print 200 on the console
            dv.Display();

            dv.print(10, 20); // without named parameters
            dv.print(y: 100, x: 200); // named parameters 
            Console.ReadKey();
        }
    }
}