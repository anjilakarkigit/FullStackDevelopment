namespace ConsoleApp2.ObjectOrientedConcepts;

// Define the IDepartmentService interface
public interface IDepartmentService
{
    void SetHead(Instructor instructor);
    void SetBudget(decimal budget);
    List<Course> GetCourses();
}