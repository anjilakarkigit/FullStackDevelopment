namespace ConsoleApp2.ObjectOrientedConcepts;

// Define the Person class, which implements IPersonService
public class Person : IPersonService
{
    private DateTime birthdate;
    private decimal salary;
    private List<string> addresses;

    public Person(DateTime birthdate, decimal salary, List<string> addresses)
    {
        this.birthdate = birthdate;
        this.salary = salary;
        this.addresses = addresses;
    }

    public int CalculateAge(DateTime birthdate)
    {
        DateTime now = DateTime.Now;
        int age = now.Year - birthdate.Year;

        if (now < birthdate.AddYears(age))
        {
            age--;
        }

        return age;

    }

    public decimal CalculateSalary(decimal baseSalary)
    {
        if (baseSalary < 0)
        {
            throw new ArgumentOutOfRangeException("Salary cannot be negative.");
        }

        return baseSalary + salary;
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }

}