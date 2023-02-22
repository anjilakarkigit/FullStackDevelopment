namespace ConsoleApp2.ObjectOrientedConcepts;

// Define the IStudentService interface, which extends IPersonService
public interface IStudentService: IPersonService
{
    void AddCourse(Course course);
    decimal CalculateGPA();
}