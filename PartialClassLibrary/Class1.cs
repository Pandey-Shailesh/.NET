namespace PartialClassLibrary
{
    public partial class Sales
    {
        private int _totalNoOfEmployees;

        public int TotalNoOfEmployees { get => _totalNoOfEmployees; set => _totalNoOfEmployees = value; }

        partial void TotalSalary();
    }
}