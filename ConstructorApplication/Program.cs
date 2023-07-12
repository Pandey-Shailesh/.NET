
namespace ConstructorApplication
{
    /// <summary>
    /// Employee Class to store the details of like empId, empAge, empAddess, empName.
    /// </summary>
    class Employee
    {
        int empId, empAge;
        string empAddress, empName;

        public Employee()
        {
            Console.WriteLine("Enter the Employee Details: ");
            Console.Write("Enter the employee Id: ");
            this.empId = int.Parse(Console.ReadLine());
            Console.Write("Enter the employee Name: ");
            this.empName = Console.ReadLine();
            Console.Write("Enter the employee Age: ");
            this.empAge = int.Parse(Console.ReadLine());
        }

        // Copy Constructor
        public Employee(Employee tempObj)
        {
            this.empId = tempObj.empId;
            this.empName = tempObj.empName;
            this.empAge = tempObj.empAge;
        }
        public void Display()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee Id: " + this.empId);
            Console.WriteLine("Employee Name: " + this.empName);
            Console.WriteLine("Employee Age: " + this.empAge);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(emp1);

            emp1.Display();
            emp2.Display();

            Console.ReadKey();
        }
    }
}