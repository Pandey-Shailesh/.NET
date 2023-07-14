namespace MakeFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Directory
            string filePath = @"D:\File\CDAC-Delhi";
            Directory.CreateDirectory(filePath);
            Console.WriteLine("Directory Created");

            string filePath2 = @"D:\File\CDAC-Delhi\cdac-Delhi.txt";

            Console.WriteLine("Enter the file contents: ");
            string contents = Console.ReadLine();

            File.WriteAllText(filePath2, contents);
            Console.WriteLine("file created");
            string showFileContents = File.ReadAllText(filePath2);
            Console.WriteLine("File Contents: ");
            Console.WriteLine(showFileContents);


            // Create Directory
             filePath = @"D:\File\CDAC-Mumbai";
            Directory.CreateDirectory(filePath);
            Console.WriteLine("Directory Created");

             filePath2 = @"D:\File\CDAC-Mumbai\cdac-mumbai.txt";

            Console.WriteLine("Enter the file contents: ");
             contents = Console.ReadLine();

            File.WriteAllText(filePath2, contents);
            Console.WriteLine("file created");
            showFileContents = File.ReadAllText(filePath2);
            Console.WriteLine("File Contents: ");
            Console.WriteLine(showFileContents);


            // Create Directory
             filePath = @"D:\File\CDAC-Pune";
            Directory.CreateDirectory(filePath);
            Console.WriteLine("Directory Created");

             filePath2 = @"D:\File\CDAC-Pune\cdac-pune.txt";

            Console.WriteLine("Enter the file contents: ");
            contents = Console.ReadLine();

            File.WriteAllText(filePath2, contents);
            Console.WriteLine("file created");
            showFileContents = File.ReadAllText(filePath2);
            Console.WriteLine("File Contents: ");
            Console.WriteLine(showFileContents);
            Console.ReadLine();
        }
    }
}