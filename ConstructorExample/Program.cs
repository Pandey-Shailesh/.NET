namespace ConstructorExample
{
    class Student
    {
        public int studentId;
        public string? studentName;
        public int marks;

        //public Student(int stdId, string stdName, int stdMarks)
        //{
        //    studentId = stdId;
        //    studentName = stdName;
        //    marks = stdMarks;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance/object for the student class
            // Object Initializer
            Student std1 = new Student() { studentId = 101, studentName = "Scott", marks = 75 };
            Student std2 = new Student() { studentId = 102, studentName = "John" };
            Student std3 = new Student() { studentId = 103 };


            Console.WriteLine("First Student Details");
            Console.WriteLine("Student ID: " + std1.studentId);
            Console.WriteLine("Student Name: " + std1.studentName);
            Console.WriteLine("Student Marks: " + std1.marks);
            Console.WriteLine(); ;
            Console.WriteLine("Second Student Details");
            Console.WriteLine("Student ID: " + std2.studentId);
            Console.WriteLine("Student Name: " + std2.studentName);
            Console.WriteLine("Student Marks: " + std2.marks);
            Console.WriteLine();
            Console.WriteLine("Third Student Details");
            Console.WriteLine("Student ID: " + std3.studentId);
            Console.WriteLine("Student Name: " + std3.studentName);
            Console.WriteLine("Student Marks: " + std3.marks);

            Console.ReadKey();
        }
    }
}