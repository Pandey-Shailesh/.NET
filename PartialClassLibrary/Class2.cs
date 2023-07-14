

namespace PartialClassLibrary
{
    public partial class Sales
    {
        partial void TotalSalary()
        {
            double totalSalary = TotalNoOfEmployees * 15000;
            Console.WriteLine("Total Salary = " +  totalSalary);
        }
    }
}
