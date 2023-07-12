namespace DestructorLibrary
{
    public class DestructorEx : System.IDisposable
    {
        // constructor

        public DestructorEx()
        {

            Console.WriteLine("File is Connected or Open");
        }

        public void databaseConnection()
        {
            Console.WriteLine("Reading table data from the database");
        }

        public void Dispose()
        {
            Console.WriteLine("Database Connection Closed");
        }

        ~DestructorEx()
        {
            Console.WriteLine("File Connection Closed");
        }
    }
}