namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, World!");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" C# Language");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Thank You!!!!!!");
            Console.ReadKey();


            //////////////////////////////////////////////////////////////

            Console.Write("Enter your first name: ");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Your Name is {0} {1}", fname, lname);
            Console.Write("Enter your company name:  ");
            string company = Console.ReadLine();
            Console.WriteLine($"Your company name is {company}");

            int age = 25;
            Console.WriteLine("your age is " + age);
            //Placeholder systax to print the output on the console
            Console.WriteLine("Company Name {0}", company);
            Console.ReadKey();




            // Read() method reads a single character from the keyboard and return the ASCII value only. 
            // it returns the integer value
            Console.Read();

            // ReadLine() will accept the string value form the keyboard and returns the string value.
            Console.ReadLine();

            // ReadKey() method reads the character from the keyboard and returns the character information given by the user. The DataType will be ConsoleKeyInfo which contanis the key information
            //Console.ReadKey();
Console.Write("Enter the first key: ");
            int key1 = Console.Read();
            Console.WriteLine("ASCII value of first key1: " + key1);
            Console.Write("Enter the second key: ");
            Console.WriteLine();
            ConsoleKeyInfo key2 = Console.ReadKey();
            Console.WriteLine("You have pressed " + key2.Key);
            Console.WriteLine("Key Character Information: " + key2.KeyChar);
            Console.WriteLine("ASCII Value: " + (int)key2.KeyChar);
            Console.ReadKey();








            // goto statement in C#
            int x = 1;
            Console.WriteLine("USA");
            Console.WriteLine("London");
            Console.WriteLine("Japan");
        myLabel:
            Console.WriteLine("India");
            Console.WriteLine("Australia");
            Console.WriteLine("Italy");
            x++;
            if (x <= 3)
            {
                goto myLabel;
            }
            Console.WriteLine("USA");
            Console.WriteLine("London");
            Console.WriteLine("Japan");

            // DataType gives these information
            // 1) Types of Result 
            // 2) Range of Data
            // 3) Size of memory location
            // 4) Legal Operation

            Console.ReadKey();
            int marks = 85;
            if (marks >= 85)
            {
                Console.WriteLine("First Division");
            }
            else
            {
                Console.WriteLine("Second Division");
            }

            char ch;
            Console.WriteLine("Enter an alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("This is vowel");
                    break;
                default:
                    Console.WriteLine("It is a consonant");
                    break;

            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }




            //int num1 = 10;
           // int* ptr = &num1;
            //Console.WriteLine("num1 is : " + num1);
           // Console.WriteLine("Address : " + (int)ptr);
           // Console.ReadKey();

           
            Console.WriteLine("Enter the Employee name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Salary of Employee");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your credit score: ");
            float credit = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Your name is :" + name);
            Console.WriteLine("Salary is : " + salary);
            Console.WriteLine("Credit Score is: " + credit);





        }
    }
}        