namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\File\cdac_delhi2.txt";
            string filePath2 = @"D:\File\cdac_delhi3.txt";
            string filePath3 = @"D:\File\cdac_delhi4.txt";
            // @ -> verbatim symbol/identifier 
            File.Create(filePath).Close();
            Console.WriteLine("file create successfully");

            bool exists = File.Exists(filePath);
            if (exists)
            {
                File.Copy(filePath, filePath2);
                Console.WriteLine("File copied successfully");

                File.Delete(filePath);
                Console.WriteLine("file deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.ReadKey();
        }
    }
}