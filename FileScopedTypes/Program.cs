namespace FileScopedTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();

            Console.WriteLine(student.GetStudentAddress());

            Console.ReadLine();
        }
    }
}