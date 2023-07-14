namespace InheritanceLibrary
{
    public abstract class Employee
    {
        //fields
        private int _empID;
        private string _empName;
        private string _location;

        // constructor
        public Employee(int empID, string empName, string location)
        {
            this._location = location;
            this._empID = empID;
            this._empName = empName;
        }

        // method hiding
        //public string GetHealthInsurance()
        //{
        //    return "Health Insurance Amount is: " + 25000;
        //}

        // virtual method 
        //public virtual string GetHealthInsurance()
        //{
        //    return "Health Insurance Amount is: " + 25000;
        //}

        // abstract method

        public abstract string GetHealthInsurance();

        //properties
        public int EmpID { get => _empID; set => _empID = value; }
        public string EmpName { get => _empName; set => _empName = value; }
        public string Location { get => _location; set => _location = value; }
    }
}