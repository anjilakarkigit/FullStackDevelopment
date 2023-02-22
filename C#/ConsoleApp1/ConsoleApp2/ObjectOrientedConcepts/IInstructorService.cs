namespace ConsoleApp2.ObjectOrientedConcepts;


// Define the IInstructorService interface, which extends IPersonService
public interface IInstructorService: IPersonService
{
    void SetDepartment(Department department);
    decimal CalculateBonusSalary(DateTime joinDate);
}