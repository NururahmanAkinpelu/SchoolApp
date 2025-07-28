using SchoolApp.Interface;
using SchoolApp.Service;

public class Program
{
    private readonly IStudentService _studentService;

    public Program(IStudentService studentService)
    {
        _studentService = studentService;
    }

    static void Main(string[] args)
    {
        var sv = new StudentService();
        Console.WriteLine("Enter your Name");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Enter your LastName");
        string LastName = Console.ReadLine();
        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your email");
        string email = Console.ReadLine();
        Console.WriteLine("Enter your address");
        string address = Console.ReadLine();
        sv.AddStudent(FirstName, LastName, email, age, address);
    }
}
