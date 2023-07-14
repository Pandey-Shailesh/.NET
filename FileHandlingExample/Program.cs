namespace FileHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\File\cdac_mumbai.txt";

            Console.WriteLine("Enter the file contents: ");
            string contents = Console.ReadLine();

            File.WriteAllText(filePath, contents);
            Console.WriteLine("cdac_mumbai.txt file created");


            string showFileContents = File.ReadAllText(filePath);
            Console.WriteLine("File Contents: ");
            Console.WriteLine(showFileContents);
            Console.ReadKey();
        }
    }
}