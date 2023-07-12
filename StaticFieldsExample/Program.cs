namespace StaticFieldsExample
{
    class Student
    {
        public int studentId;
        public string studentName;
        public int marks;

        public static string collegeName;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.studentId = 123;
            s1.studentName = "John";
            s1.marks = 450;

            s2.studentId = 234;
            s2.studentName = "Mark";
            s2.marks = 350;

            Console.WriteLine("Student Id: " + s1.studentId);
            Console.WriteLine("Student Name: " + s1.studentName);
            Console.WriteLine("Student Marks: " + s1.marks);

            Console.WriteLine("Student Id: " + s2.studentId);
            Console.WriteLine("Student Name: " + s2.studentName);
            Console.WriteLine("Student Marks: " + s2.marks);

            Student.collegeName = "ABC College of Institute";
            Console.WriteLine("College Name: " + Student.collegeName);

            Console.ReadLine();
        }
    }
}