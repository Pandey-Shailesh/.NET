namespace CopyConstructor
{
    class Employee
    {
        int eid, age;
        string address, name;
        public Employee()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS");
            Console.WriteLine("Enter the employee id");
            this.eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee age");
            this.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee name");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter the employee address:");
            this.address = Console.ReadLine();
        }
        public Employee(Employee tempobj)
        {
            this.eid = tempobj.eid;
            this.age = tempobj.age;
            this.name = tempobj.name;
            this.address = tempobj.address;
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Employee id is:  " + this.eid);
            Console.WriteLine("Employee name is:  " + this.name);
            Console.WriteLine("Employee age is:  " + this.age);
            Console.WriteLine("Employee address is:  " + this.address);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Employee e2 = new Employee(e1);
            e1.Display();
            e2.Display();

            Console.ReadKey();
        }
    }
}