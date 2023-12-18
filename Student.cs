public class StudentAndTeacherEntity : PersonEntity
{
    public int StudentId { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    public StudentAndTeacherEntity(string firstName, string lastName, DateTime birthDate, string address, int studentId, string major, double gpa)
    : base(firstName, lastName, birthDate, address)
    {
        StudentId = studentId;
        Major = major;
        GPA = gpa;
    }

    public override void DisplayPersonInfo()
    {
        base.DisplayPersonInfo();
        Console.WriteLine($"ID: {StudentId}");
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"GPA: {GPA:F2}");
    }

    public void StudyHard()
    {
        Console.WriteLine($"Student {FirstName} is studying hard for exams.");
    }

    public void AttendClass()
    {
        Console.WriteLine($"Student {FirstName} is attending a class in {Major}.");
        AttendanceCount++;
    }

    public void PlaySports()
    {
        Console.WriteLine($"Student {FirstName} is playing sports in their free time.");
    }
}