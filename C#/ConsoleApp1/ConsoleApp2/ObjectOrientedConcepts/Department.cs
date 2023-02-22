namespace ConsoleApp2.ObjectOrientedConcepts;

public class Department: IDepartmentService
{
    private Instructor head;
    private decimal budget;
    private List<Course> courses;
    
    public void SetHead(Instructor instructor)
    {
        head = instructor;
    }

    public void SetBudget(decimal budget)
    {
        if (budget < 0)
        {
            throw new ArgumentOutOfRangeException("Budget cannot be negative.");
        }

        this.budget = budget;
    }

    public List<Course> GetCourses()
    {
        return courses;
    }


}