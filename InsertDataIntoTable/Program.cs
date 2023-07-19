using MySql.Data.MySqlClient;

namespace InsertDataIntoTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept the values from the user
            Console.Write("Enter the Employee ID: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter the Employee salary: ");
            decimal empSalary = Convert.ToDecimal(Console.ReadLine());
           
            try
            {
                // mysql connection string 
                string connStr = "server=localhost;user=root;password=Shailesh@123;database=Company;port=3306";
                MySqlConnection con = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                MySqlParameter p1, p2, p3;
                p1 = new MySqlParameter();
                p2 = new MySqlParameter();
                p3 = new MySqlParameter();

                //con.ConnectionString = connStr;
                cmd.CommandText = "insert into employees values(@EID, @EmpName, @Salary)";
                cmd.Connection = con;
                p1.ParameterName = "@EID";
                p2.ParameterName = "@EmpName";
                p3.ParameterName = "@Salary";

                p1.Value = empId;
                p2.Value = empName;
                p3.Value = empSalary;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                // Open the Connection
                con.Open();
                int noOfRows = cmd.ExecuteNonQuery();
                Console.WriteLine(noOfRows + " no of rows inserted succussfully");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("MySQL Connection gets Closed");
            Console.ReadKey();
        }
    }
}