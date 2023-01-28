namespace Lab4;

public delegate void EmployeeSalaryIncrease(int increase);

public class Employee
{
    public string Name { get; set; }

    public int Salary { get; set; }

    public event EmployeeSalaryIncrease OnSalaryIncreased;

    public void IncreaseSalary(int increase)
    {
        Salary += increase;
        
        if (OnSalaryIncreased is not null)
        {
            OnSalaryIncreased.Invoke(increase);
        }
    }
}

public class Company
{
    public string Name { get; set; }

    public int Budget { get; set; }

    public List<Employee> Employees { get; set; }

    public void ReduceBudgetByEmployeeIncrease(int amount)
    {
        Budget -= amount;
    }

    public List<Employee> FilterEmployees(Predicate<Employee> salaryPredicate)
    {
        List<Employee> results = new List<Employee>();

        foreach (Employee emp in Employees)
        {
            if (salaryPredicate.Invoke(emp))
            {
                results.Add(emp);
            }
        }

        return results;
    }

}