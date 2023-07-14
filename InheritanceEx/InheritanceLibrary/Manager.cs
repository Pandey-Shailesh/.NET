namespace InheritanceLibrary
{
    public sealed class Manager : Employee
    {
        // fields
        private string _departmentName;

        public Manager(int empID, string empName, string location, string departmentName) : base(empID, empName, location)
        {
            this._departmentName = departmentName;
        }

        public string DepartmentName { get => _departmentName; set => _departmentName = value; }

        // method
        public string GetDepartmentName()
        {
            return DepartmentName + " Department" + " located at " + base.Location;
        }

        // method hiding
        //public new string GetHealthInsurance()
        //{
        //    return "Health Insurance Amount is: " + 45000;
        //}


        // method overriding
        //public override string GetHealthInsurance()
        //{
        //    Console.WriteLine(base.GetHealthInsurance()); // calling the parent class method
        //    return "Health Insurance Amount is: " + 45000;
        //}

        // abstract method 
        public override string GetHealthInsurance()
        {
            return "Health Insurance Amount is: " + 45000;
        }

        public long GetTotalSalesOfTheYear()
        {
            return 2500000;
        }
    }
}
