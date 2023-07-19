using MySql.Data.MySqlClient;
namespace MySQLConnectionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String connStr = "server=localhost;user=root;password=Shailesh@123;database=company;port=3306";
            MySqlConnection conn = new MySqlConnection(connStr);
            try {
                Console.WriteLine("Connection to MySQL Server...");
                conn.Open();

                //execute the mySql query
                String mySqlQuery = "Select * from Employees";
                //count total number of records in the table
                MySqlCommand cmd2 = new MySqlCommand(mySqlQuery, conn);
                object obj = cmd2.ExecuteScalar();
                string str = Convert.ToString(obj);
                MySqlCommand cmd = new MySqlCommand(mySqlQuery,conn);
                MySqlDataReader reader = cmd.ExecuteReader();

               
                Console.WriteLine("Total no. of record is:"+ str);
                //reading the data  from the table 
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]);
                }
                reader.Close();
                Console.WriteLine("Connection is closed..."); 
            }
            catch (MySqlException ex) {
            Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}