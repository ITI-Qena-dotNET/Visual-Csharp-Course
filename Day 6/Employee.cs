namespace Lab6;

public class Employee : IComparable<Employee>
{
    public int ID { get; set; }
    
    public string Name { get; set; }
    
    public int Age { get; set; }
    
    public int Salary { get; set; }
    
    public int YearsOfExperience { get; set; }

    public int DepartmentID { get; set; }

    public string ChangeEmployeeDepartment { get; set; }

    public event ChangeEmployeeDepartment OnChangeDepartment;

    public Employee() 
        => OnChangeDepartment += Department.UpdateEmployeeDepartment;

    public void ChangeDepartment(int newDeparmentId)
    {
        Console.WriteLine($"Publisher: Attempt to update employee {Name} to Department {newDeparmentId}");
        OnChangeDepartment?.Invoke(this, newDeparmentId);
    }

    public int CompareTo(Employee other) 
        => YearsOfExperience.CompareTo(other.YearsOfExperience);
}

public delegate void ChangeEmployeeDepartment(Employee employee, int departmentId);

public class EmployeeSalaryComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
        => x.Salary.CompareTo(y.Salary);
}