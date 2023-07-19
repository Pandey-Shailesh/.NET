namespace LINQ
{

    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Collections of Objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {EmpId= 101, EmpName="John", Job="Centre Head", Salary=75000},
                new Employee() {EmpId= 102, EmpName="Kate", Job="SPE", Salary=78000},
                new Employee() {EmpId= 103, EmpName="Micheal", Job="Clerk", Salary=72000},
                new Employee() {EmpId= 104, EmpName="Anderson", Job="Director", Salary=75000},
            };

            //var result = employees.Where(emp => emp.Job == "Director");

            IEnumerable<Employee> result = employees.Where(emp => emp.Salary == 75000);

            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpId + " , " + item.EmpName + " , " + item.Job + " , " + item.Salary);
            }

            Console.WriteLine("\n\n");

            // Sorted Data 
            Console.WriteLine("Sorted Data: ");
            IOrderedEnumerable<Employee> sortedData = employees.OrderBy(emp => emp.Salary);
            foreach (Employee item in sortedData)
            {
                Console.WriteLine(item.EmpId + " , " + item.EmpName + " , " + item.Job + " , " + item.Salary);
            }
            Console.WriteLine("\n\n");
            // Min, Max, Sum , Average, Count
            int minSalary = employees.Min(temp => temp.Salary);
            int maxSalary = employees.Max(temp => temp.Salary);
            double averageSalary = employees.Average(temp => temp.Salary);
            int noOfEmployee = employees.Count();
            Console.WriteLine("Minimum Salary is: " + minSalary);
            Console.WriteLine("Maximum Salary is: " + maxSalary);
            Console.WriteLine("Average Salary is: " + averageSalary);
            Console.WriteLine("Total no. of employees: " + noOfEmployee);
            Console.ReadKey();

        }
    }
}