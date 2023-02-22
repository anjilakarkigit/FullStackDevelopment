namespace ConsoleApp2.ObjectOrientedConcepts;

public interface IPersonService
{
        int CalculateAge(DateTime birthdate);
        decimal CalculateSalary(decimal baseSalary);
        List<string> GetAddresses();

}