

namespace InheritanceLibrary
{
    public class SalesMan : Employee
    {
        // fields
        private string _region;

        public SalesMan(int empID, string empName, string location, string region) : base(empID, empName, location)
        {
            _region = region;
        }

        public string Region { get => _region; set => _region = value; }

        // abstract method overrding
        public override string GetHealthInsurance()
        {
            return "Health Insurance Amount is: " + 25000;
        }

        public long GetTotalSalesOfMonth()
        {
            return 50000;
        }
    }
}
