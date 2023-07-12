using EmployeeLibray;

namespace StaticContructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee emp1 = new Employee(101, "John", "Manager");
            Employee emp2 = new Employee(102, "Kate", "Centre Head");
            Employee emp3 = new Employee(103, "Michael", "Developer");

            Console.WriteLine("First Employee Details");
            Console.WriteLine("Employee Id: " + emp1.empId);
            Console.WriteLine("Employee Name: " + emp1.empName);
            Console.WriteLine("Employee Job Title: " + emp1.job);

            Console.WriteLine();

            Console.WriteLine("Second Employee Details");
            Console.WriteLine("Employee Id: " + emp2.empId);
            Console.WriteLine("Employee Name: " + emp2.empName);
            Console.WriteLine("Employee Job Title: " + emp2.job);

            Console.WriteLine();

            Console.WriteLine("Third Employee Details");
            Console.WriteLine("Employee Id: " + emp3.empId);
            Console.WriteLine("Employee Name: " + emp3.empName);
            Console.WriteLine("Employee Job Title: " + emp3.job);

            Console.ReadKey();
        }
    }
}