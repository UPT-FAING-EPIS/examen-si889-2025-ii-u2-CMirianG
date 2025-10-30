namespace EmployeeApp;

public abstract class Employee
{
    public string Name { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public abstract T Accept<T>(IEmployeeVisitor<T> visitor);
}

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; } = string.Empty;

    public override T Accept<T>(IEmployeeVisitor<T> visitor)
    {
        return visitor.Visit(this);
    }
}

public class Manager : Employee
{
    public int TeamSize { get; set; }

    public override T Accept<T>(IEmployeeVisitor<T> visitor)
    {
        return visitor.Visit(this);
    }
}

public interface IEmployeeVisitor<T>
{
    T Visit(Developer developer);
    T Visit(Manager manager);
}

public sealed class ReportVisitor : IEmployeeVisitor<string>
{
    public string Visit(Developer developer)
    {
        return $"Developer: {developer.Name}, Language: {developer.ProgrammingLanguage}, Salary: {developer.Salary}";
    }

    public string Visit(Manager manager)
    {
        return $"Manager: {manager.Name}, Team Size: {manager.TeamSize}, Salary: {manager.Salary}";
    }
}


