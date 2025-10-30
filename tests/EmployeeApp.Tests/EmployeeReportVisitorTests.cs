using EmployeeApp;
using Xunit;

namespace EmployeeApp.Tests;

public class EmployeeReportVisitorTests
{
    [Fact]
    public void Should_Generate_Developer_Report()
    {
        var dev = new Developer
        {
            Name = "Alice",
            Salary = 80000,
            ProgrammingLanguage = "C#"
        };

        var report = dev.Accept(new ReportVisitor());
        Assert.Equal("Developer: Alice, Language: C#, Salary: 80000", report);
    }

    [Fact]
    public void Should_Generate_Manager_Report()
    {
        var mgr = new Manager
        {
            Name = "Bob",
            Salary = 100000,
            TeamSize = 5
        };

        var report = mgr.Accept(new ReportVisitor());
        Assert.Equal("Manager: Bob, Team Size: 5, Salary: 100000", report);
    }
}


