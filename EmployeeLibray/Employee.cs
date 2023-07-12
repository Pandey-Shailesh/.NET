namespace EmployeeLibray
{
    public class Employee
    {
        public int empId;
        public string empName;
        public string job;

        // static field
        public static string companyName;

        public Employee()
        {
            Console.WriteLine("Default Constructor");
        }
        public Employee(int empId, string empName, string job)
        {
            this.empId = empId;
            this.empName = empName;
            this.job = job;

        }

        //static constructor
        static Employee()
        {
            companyName = "ABC Pvt. Ltd.";
            Console.WriteLine(companyName);
        }
    }
}