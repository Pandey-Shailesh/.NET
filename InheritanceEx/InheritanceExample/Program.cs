using InheritanceLibrary;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of an Employee Class
            // Employee emp1 = new Employee(101, "John", "New Delhi"); // for abstract it is not allowed 
            Employee emp1 = new Manager(101, "John", "New Delhi", "Marketing");
            //emp1.EmpID = 101;
            //emp1.EmpName = "John";
            //emp1.Location = "New Delhi";

            Console.WriteLine("Parent Class Object Details: ");
            Console.WriteLine("Employee ID: " + emp1.EmpID);
            Console.WriteLine("Employee Name: " + emp1.EmpName);
            Console.WriteLine("Employee Location: " + emp1.Location);
            Console.WriteLine();

            // create an object for the manager class
            Manager mgr1 = new Manager(102, "Micheal", "Mumbai", "Marketing");
            //mgr1.EmpID = 102;
            //mgr1.EmpName = "Michael";
            //mgr1.Location = "Mumbai";
            //mgr1.DepartmentName = "Marketing";
            Console.WriteLine("Child Class(Manager Class) Object Details: ");
            Console.WriteLine("Employee ID: " + mgr1.EmpID);
            Console.WriteLine("Employee Name: " + mgr1.EmpName);
            Console.WriteLine("Employee Location: " + mgr1.Location);
            Console.WriteLine("Employee Department: " + mgr1.DepartmentName);
            Console.WriteLine(mgr1.GetDepartmentName());
            Console.WriteLine(mgr1.GetHealthInsurance());
            Console.WriteLine();


            // create an object for the manager class
            SalesMan salesMan1 = new SalesMan(103, "Kate", "Kolkatta", "South Delhi");
            //salesMan1.EmpID = 103;
            //salesMan1.EmpName = "Kate";
            //salesMan1.Location = "Kolkatta";
            //salesMan1.Region = "South Delhi";
            Console.WriteLine("Child Class(SalesMan Class) Object Details: ");
            Console.WriteLine("Employee ID: " + salesMan1.EmpID);
            Console.WriteLine("Employee Name: " + salesMan1.EmpName);
            Console.WriteLine("Employee Location: " + salesMan1.Location);
            Console.WriteLine("Employee Region: " + salesMan1.Region);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}