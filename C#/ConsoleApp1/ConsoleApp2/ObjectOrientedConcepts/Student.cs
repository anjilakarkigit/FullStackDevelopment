namespace ConsoleApp2.ObjectOrientedConcepts;

public class Student : Person, IStudentService
{
    private List<Course> courses;

    public Student(DateTime birthdate, decimal salary, List<string> addresses) : base(birthdate, salary, addresses)
    {
        courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public decimal CalculateGPA()
    {
        decimal totalPoints = 0;
        decimal totalCredits = 0;

        foreach (Course course in courses)
        {
            switch (course.Grade)
            {
                case "A":
                    totalPoints += 4;
                    break;
                case "B":
                    totalPoints += 3;
                    break;
                case "C":
                    totalPoints += 2;
                    break;
                case "D":
                    totalPoints += 1;
                    break;
                case "F":
                    totalPoints += 0;
                    break;
                default:
                    throw new ArgumentException("Invalid grade");
            }
            totalCredits += course.Credits;
        }
        return totalPoints / totalCredits;
    }
}