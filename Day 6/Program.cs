using Lab6;

Console.WriteLine("Hello, World!");

Department companyDepartment = new Department()
{
    Name = "TestDepartment1"
};

Employee emp1 = new()
{
    ID = 1,
    Name = "Emp1",
    Age = Random.Shared.Next(23, 40),
    YearsOfExperience = Random.Shared.Next(23, 40),
    Salary = Random.Shared.Next(1000, 10000)
};

Employee emp2 = new()
{
    ID = 2,
    Name = "Emp2",
    Age = Random.Shared.Next(23, 40),
    YearsOfExperience = Random.Shared.Next(23, 40),
    Salary = Random.Shared.Next(1000, 10000)
};

Employee emp3 = new()
{
    ID = 3,
    Name = "Emp3",
    Age = Random.Shared.Next(23, 40),
    YearsOfExperience = Random.Shared.Next(23, 40),
    Salary = Random.Shared.Next(1000, 10000)
};

Employee emp4 = new()
{
    ID = 4,
    Name = "Emp4",
    Age = Random.Shared.Next(23, 40),
    YearsOfExperience = Random.Shared.Next(23, 40),
    Salary = Random.Shared.Next(1000, 10000)
};

Employee emp5 = new()
{
    ID = 5,
    Name = "Emp5",
    Age = Random.Shared.Next(23, 40),
    YearsOfExperience = Random.Shared.Next(23, 40),
    Salary = Random.Shared.Next(1000, 10000)
};

companyDepartment.EmployeesArray = new[] { emp1, emp2, emp3, emp4, emp5 };
companyDepartment.EmployeesList = companyDepartment.EmployeesArray.ToList();
Department.EmployeesDictionary = companyDepartment.EmployeesArray.ToDictionary(x => x.ID);
Department.NumberOfEmployees = Department.EmployeesDictionary.Count;

Console.WriteLine("Sort Array by Years of Experience");
companyDepartment.SortArrayByExperience();
companyDepartment.DisplayCollection(companyDepartment.EmployeesArray);

Console.WriteLine("Sort Array by Salary");
companyDepartment.SortArrayBySalary();
companyDepartment.DisplayCollection(companyDepartment.EmployeesArray);

Console.WriteLine("Sort List by Years of Experience");
companyDepartment.SortListByExperience();
companyDepartment.DisplayCollection(companyDepartment.EmployeesList);

Console.WriteLine("Sort List by Salary");
companyDepartment.SortListBySalary();
companyDepartment.DisplayCollection(companyDepartment.EmployeesList);

Console.WriteLine($"Current employees in department: {Department.NumberOfEmployees}");

companyDepartment.EmployeesArray[0].ChangeDepartment(10);
Console.WriteLine($"Current employees in department: {Department.NumberOfEmployees}");
