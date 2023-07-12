using DestructorLibrary;

namespace DestructorExample
{
    internal class Program
    {
        static void cleanUpAction()
        {
            using DestructorEx de = new DestructorEx();
            de.databaseConnection();
        }
        static void Main(string[] args)
        {

            cleanUpAction();
            Console.ReadKey();
        } // destructor will called here

    }
}