namespace Lab6;

public class Department
{
    public string Name { get; set; }

    public static int NumberOfEmployees { get; set; }

    public Employee[] EmployeesArray;

    public List<Employee> EmployeesList;

    public static Dictionary<int, Employee> EmployeesDictionary { get; set; }

    public void SortArrayByExperience() => Array.Sort(EmployeesArray);

    public void SortArrayBySalary() => Array.Sort(EmployeesArray, new EmployeeSalaryComparer());

    public void SortListByExperience() => EmployeesList.Sort();

    public void SortListBySalary() => EmployeesList.Sort(new EmployeeSalaryComparer());

    public void DisplayCollection(IEnumerable<Employee> collection)
    {
        foreach (var emp in collection)
        {
            Console.WriteLine($"Employee {emp.Name} with ID {emp.ID} has Salary {emp.Salary} for experience {emp.YearsOfExperience}.");
        }

        Console.WriteLine("----------------------");
    }

    public static void UpdateEmployeeDepartment(Employee employee, int newDepartmentId)
    {
        if (EmployeesDictionary.ContainsKey(employee.ID))
        {
            Console.WriteLine($"Subscriber: Changing employee {employee.Name} to Department {newDepartmentId}");
            EmployeesDictionary.Remove(employee.ID);
            employee.DepartmentID = newDepartmentId;
            NumberOfEmployees--;
        }
    }

}
