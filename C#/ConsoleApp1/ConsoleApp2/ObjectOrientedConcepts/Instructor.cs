namespace ConsoleApp2.ObjectOrientedConcepts;

public class Instructor: Person, IInstructorService
{
    private Department department;

    public Instructor(DateTime birthdate, decimal salary, List<string> addresses) : base(birthdate, salary, addresses)
    {
    }

    public void SetDepartment(Department department)
    {
        this.department = department;
    }

    public decimal CalculateBonusSalary(DateTime joinDate)
    {
        int yearsOfExperience = DateTime.Now.Year - joinDate.Year;
        return yearsOfExperience * 1000;
    }
}