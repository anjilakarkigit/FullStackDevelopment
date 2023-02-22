namespace ConsoleApp2.ObjectOrientedConcepts;

// Define the ICourseService interface
public interface ICourseService
{
    void AddStudent(Student student);
    List<Student> GetEnrolledStudents();
}