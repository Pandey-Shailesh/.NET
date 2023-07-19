using MySql.Data.MySqlClient;

namespace DeleteRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept the values from the user
            Console.Write("Enter the Employee ID: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            try
            {
                // mysql connection string 
                string connStr = "server=localhost;user=root;password=Shailesh@123;database=Company;port=3306";
                MySqlConnection con = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                MySqlParameter p1;
                p1 = new MySqlParameter();
              
                //con.ConnectionString = connStr;
                cmd.CommandText = "DELETE FROM employees WHERE eid=@EID;";
                cmd.Connection = con;
                p1.ParameterName = "@EID";
               
                p1.Value = empId;
               
                cmd.Parameters.Add(p1);
               
                // Open the Connection
                con.Open();
                int noOfRows = cmd.ExecuteNonQuery();
                Console.WriteLine(noOfRows + " no of row deleted succussfully");
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